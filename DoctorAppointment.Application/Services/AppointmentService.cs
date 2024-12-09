using System;
using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Application.Services;

public class AppointmentService(IAppointmentRepo appointmentRepo,IPatientRepo patientRepo, IScheduleService scheduleService, IUnitOfWork unitOfWork, IMapper mapper, ICurrentUser currentUser)
    : BaseService(unitOfWork, mapper, currentUser), IAppointmentService
{
    public async Task<Appointment> GetDoctorAppointmentsAsync(int doctorId, DateTime date)
    {
        throw new NotImplementedException();
    }

    public async Task<Appointment> GetPatientAppointmentsAsync(int patientId, DateTime date)
    {
        throw new NotImplementedException();
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
        return true;
    }   
}

