using AutoMapper;
using DoctorAppointment.Application.Commons.Helpers;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace DoctorAppointment.Application.Services;

public class AppointmentService(
    IAppointmentRepo appointmentRepo,
    IPatientRepo patientRepo,
    IDoctorRepo doctorRepo,
    IScheduleService scheduleService,
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    IMailTemplateHelper mailTemplateHelper,
    IEmailSender emailSender)
    : BaseService(unitOfWork, mapper, currentUser), IAppointmentService
{
    public async Task<PagingItem<AppointmentViewModel>> GetPatientAppointmentsAsync(AppointmentSearchModel model,
        int page, int pageSize)
    {
        var currentUserId = int.Parse(CurrentUser.Id);
        var patient = await patientRepo.GetPatientByUserIdAsync(currentUserId);
        if (patient == null)
            throw new Exception("Patient not found");
        var query = appointmentRepo.GetPatientAppointmentsQuery(patient.Id, model.From, model.To, model.Status)
            .OrderByDescending(x => x.LastModifiedAt);
        var (appointments, count) = await appointmentRepo.ApplyPaing(query, page, pageSize);
        return new PagingItem<AppointmentViewModel>
        {
            Items = Mapper.Map<List<AppointmentViewModel>>(appointments),
            CountPages = (int)Math.Ceiling(count / (double)pageSize),
            CurrentPage = page,
            PageSize = pageSize,
            PageUrl = i => $"/appointments/patient?page={i}&from={model.From}&to={model.To}&status={model.Status}"
        };
        // return Mapper.Map<List<AppointmentViewModel>>(appointments);
        // throw new NotImplementedException();
    }

    public async Task<PagingItem<AppointmentViewModel>> GetDoctorAppointmentsAsync(AppointmentSearchModel model,
        int page, int pageSize)
    {
        var currentUserId = int.Parse(CurrentUser.Id);
        var doctor = await doctorRepo.GetDoctorByUserIdAsync(currentUserId);
        if (doctor == null)
            throw new Exception("Doctor not found");
        var query = appointmentRepo.GetDoctorAppointmentsQuery(doctor.Id, model.From, model.To, model.Status)
            .OrderByDescending(x => x.LastModifiedAt);
        var (appointments, count) = await appointmentRepo.ApplyPaing(query, page, pageSize);
        return new PagingItem<AppointmentViewModel>
        {
            Items = Mapper.Map<List<AppointmentViewModel>>(appointments),
            CountPages = (int)Math.Ceiling(count / (double)pageSize),
            CurrentPage = page,
            PageSize = pageSize,
            PageUrl = i => $"/appointments/doctor?page={i}&from={model.From}&to={model.To}&status={model.Status}"
        };
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
        if (date.Date == DateTime.Today.Date) start = new TimeSpan(DateTime.UtcNow.ToLocalTime().Hour + 1, 0, 0);
        //duration 1 hour
        var duration = new TimeSpan(1, 0, 0);
        while (start < end)
        {
            if (appointments.All(a => a.StartTime != start)) timeSlots.Add(start);
            start = start.Add(duration);
        }

        return timeSlots;
    }

    public async Task<Appointment> CreateAppointmentAsync(AppointmentPostModel model)
    {
        var appointment = Mapper.Map<Appointment>(model);
        var doctor = await doctorRepo.GetByIdAsync(appointment.DoctorId.Value);
        if (doctor?.UserId == int.Parse(CurrentUser.Id)) return null;
        appointment.EndTime = appointment.StartTime?.Add(new TimeSpan(1, 0, 0));
        var patient = await patientRepo.GetPatientByUserIdAsync(int.Parse(CurrentUser.Id));
        appointment.PatientId = patient.Id;
        appointmentRepo.Add(appointment);
        await UnitOfWork.SaveChangesAsync();
        var appointmentInfo = await appointmentRepo.GetAppointmentAsync(appointment.Id);
        var template = mailTemplateHelper.GetAppointmentInfoTemplate(appointment);
        var message = new Message(new List<string> { appointment.Patient.User.Email! }, "Thông tin lịch hẹn", template);
        _ = emailSender.SendEmailAsync(message);
        return appointmentInfo;
    }

    public async Task<Appointment> CancelAppointmentAsync(int id)
    {
        var appointment = await appointmentRepo.QueryGetById(id)
            .Include(a => a.Doctor.User)
            .Include(a => a.Patient.User)
            .FirstOrDefaultAsync();
        if (appointment == null)
            return null;
        appointment.Status = AppointmentStatus.Cancelled;
        await UnitOfWork.SaveChangesAsync();
        var template = mailTemplateHelper.GetCancelAppointmentTemplate(appointment);
        var message = new Message(new List<string> { appointment.Patient.User.Email! }, "Thông tin hủy lịch hẹn",
            template);
        _ = emailSender.SendEmailAsync(message);
        return appointment;
    }

    public async Task<Appointment> ConfirmAppointmentAsync(int id)
    {
        var appointment = await appointmentRepo.QueryGetById(id)
            .Include(a => a.Doctor.User)
            .Include(a => a.Patient.User)
            .FirstOrDefaultAsync();
        if (appointment == null)
            return null;
        appointment.Status = AppointmentStatus.Confirmed;
        await UnitOfWork.SaveChangesAsync();
        var template = mailTemplateHelper.GetConfirmedAppointmentTemplate(appointment);
        var message = new Message(new List<string> { appointment.Patient.User.Email! }, "Thông tin xác nhận lịch hẹn",
            template);
        _ = emailSender.SendEmailAsync(message);
        return appointment;
    }

    public async Task<AppointmentViewModel> GetAppointmentByIdAsync(int id)
    {
        var appointment = appointmentRepo.QueryGetById(id)
            .Include(a => a.Doctor.User)
            .Include(a => a.Patient.User)
            .FirstOrDefault();
        return Mapper.Map<AppointmentViewModel>(appointment);
    }
    public async Task<List<AppointmentViewModel>> GetAllDoctorAppointmentsAsync()
    {
        var doctor = await doctorRepo.GetDoctorByUserIdAsync(int.Parse( CurrentUser.Id));
        var appointments = appointmentRepo
            .GetDoctorAppointmentsQuery(doctor.Id, DateTime.MinValue, DateTime.MaxValue, AppointmentStatus.Confirmed)
            .Concat(appointmentRepo.GetDoctorAppointmentsQuery(doctor.Id, DateTime.MinValue, DateTime.MaxValue, AppointmentStatus.Completed));
        return Mapper.Map<List<AppointmentViewModel>>( await appointments.ToListAsync());
    }

    public async Task<bool> UpdateAppointmentNotesAsync(int id, string notes)
    {
        var appointment = await appointmentRepo.GetByIdAsync(id);
        if (appointment == null)
            return false;
        appointment.Notes = notes;
        await UnitOfWork.SaveChangesAsync();
        return true;
    }

    public async Task<bool> CheckAppointmentAsync(int doctorId)
    {
        var patient = await patientRepo.GetPatientByUserIdAsync(int.Parse(CurrentUser.Id));
        return await appointmentRepo.CheckAppointmentAsync(doctorId, patient.Id);
    }
}