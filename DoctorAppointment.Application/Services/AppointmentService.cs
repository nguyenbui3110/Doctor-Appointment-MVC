using System;
using AutoMapper;
using DoctorAppointment.Application.Commons.Helpers;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Services;

public class AppointmentService(IAppointmentRepo appointmentRepo,IPatientRepo patientRepo,
                                IScheduleService scheduleService, IUnitOfWork unitOfWork,
                                 IMapper mapper, ICurrentUser currentUser,
                                 IMailTemplateHelper mailTemplateHelper, IEmailSender emailSender)
    : BaseService(unitOfWork, mapper, currentUser), IAppointmentService
{
    public async Task<Appointment> GetDoctorAppointmentsAsync(int doctorId, DateTime date)
    {
        throw new NotImplementedException();
    }

    public async Task<List<AppointmentViewModel>> GetPatientAppointmentsAsync(AppointmentSearchModel model)
    {
        var currentUserId = int.Parse(CurrentUser.Id);
        var patient = await patientRepo.GetPatientByUserIdAsync(currentUserId);
        if (patient == null)
            throw new Exception("Patient not found");
        var appointments = await appointmentRepo.GetPatientAppointmentsAsync(patient.Id, model.From, model.To, model.Status);
        return Mapper.Map<List<AppointmentViewModel>>(appointments);
        // throw new NotImplementedException();
    }

    public async Task<IEnumerable<TimeSpan>> GetFreeTimeSlotsAsync(int doctorId, DateTime date)
    {
        var schedule = await scheduleService.GetDoctorScheduleAsync(doctorId, date.DayOfWeek);
        if (schedule == null)
            throw new Exception("Schedule not found");
        var appointments = await appointmentRepo.GetDoctorAppointmentsAsync(doctorId, date);
        var timeSlots = new List<TimeSpan>();
        var start = schedule.StartTime;
        var end = schedule.EndTime;
        if(date.Date==DateTime.Today.Date)
        {
            start = new TimeSpan(DateTime.UtcNow.ToLocalTime().Hour+1,0,0);
        }
        //duration 1 hour
        var duration = new TimeSpan(1, 0, 0);
        while (start < end)
        {
            if (appointments.All(a => a.StartTime != start))
            {
                timeSlots.Add(start);
            }
            start = start.Add(duration);
        }
        return timeSlots;
    }
    public async Task<bool> CreateAppointmentAsync(AppointmentPostModel model)
    {
        var appointment = Mapper.Map<Appointment>(model);
        appointment.EndTime = appointment.StartTime?.Add(new TimeSpan(1,0,0));
        appointment.PatientId = int.Parse(CurrentUser.Id);
        var patient = await patientRepo.GetPatientByUserIdAsync(appointment.PatientId.Value);
        appointment.PatientId = patient.Id;
        if(appointment.DoctorId == appointment.PatientId)
        {
            return false;
        }
        appointmentRepo.Add(appointment);
        await UnitOfWork.SaveChangesAsync();
        var appointmentInfo = await appointmentRepo.GetAppointmentAsync(appointment.Id);
        var template = mailTemplateHelper.GetAppointmentInfoTemplate(appointment);
        var message = new Message(new List<string> {appointment.Patient.User.Email!}, "Thông tin lịch hẹn", template);
        await emailSender.SendEmailAsync(message);
        return true;
    }

    public async Task<bool> CancelAppointmentAsync(int id)
    {
        var appointment = await appointmentRepo.GetByIdAsync(id);
        if (appointment == null)
            return false;
        appointment.Status = AppointmentStatus.Cancelled;
        await UnitOfWork.SaveChangesAsync();
        return true;
        
    }
}

