using System;
using DoctorAppointment.Application.Commons.Helpers;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Enums;
using Quartz;

namespace DoctorAppointment.Application.BackgroundServices;

public class RemindAppointmentJob : IJob
{
    private readonly IAppointmentRepo _appointmentRepo;
    private readonly IEmailSender _emailSender;
    private readonly IMailTemplateHelper _mailTemplateHelper;
    public RemindAppointmentJob(IAppointmentRepo appointmentRepo, IEmailSender emailSender, IMailTemplateHelper mailTemplateHelper)
    {
        _appointmentRepo = appointmentRepo;
        _emailSender = emailSender;
        _mailTemplateHelper = mailTemplateHelper;
    }
    public async Task Execute(IJobExecutionContext context)
    {
        var todayAppointments = await _appointmentRepo.GetAppointmentsByDateAsync(DateTime.Today);
        foreach (var appointment in todayAppointments)
        {
            if(appointment.Status != AppointmentStatus.Confirmed) continue;
            var template = _mailTemplateHelper.GetRemindAppointmentTemplate(appointment);
            var message = new Message(new List<string> {appointment.Patient.User.Email!}, "nhắc lịch hẹn", template);
            // await _emailSender.SendEmailAsync(message);
        }
    }
}
