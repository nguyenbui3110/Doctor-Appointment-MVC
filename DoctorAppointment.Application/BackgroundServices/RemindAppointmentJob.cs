using DoctorAppointment.Application.Commons.Helpers;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Enums;
using Microsoft.Extensions.Logging;
using Quartz;

namespace DoctorAppointment.Application.BackgroundServices;

public class RemindAppointmentJob : IJob
{
    private readonly IAppointmentRepo _appointmentRepo;
    private readonly IEmailSender _emailSender;
    private readonly IMailTemplateHelper _mailTemplateHelper;
    private readonly ILogger<RemindAppointmentJob> _logger;

    public RemindAppointmentJob(IAppointmentRepo appointmentRepo, IEmailSender emailSender,
        IMailTemplateHelper mailTemplateHelper, ILogger<RemindAppointmentJob> logger)
    {
        _appointmentRepo = appointmentRepo;
        _emailSender = emailSender;
        _mailTemplateHelper = mailTemplateHelper;
        _logger = logger;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        var tomorrowAppointments = await _appointmentRepo.GetAppointmentsByDateAsync(DateTime.Today.AddDays(1));
        _logger.LogInformation($"Found {tomorrowAppointments.Count} appointments for tomorrow");
        foreach (var appointment in tomorrowAppointments)
        {
            if (appointment.Status != AppointmentStatus.Confirmed) continue;
            var template = _mailTemplateHelper.GetRemindAppointmentTemplate(appointment);
            var message = new Message(new List<string> { appointment.Patient.User.Email! }, "nhắc lịch hẹn", template);
            await _emailSender.SendEmailAsync(message);
        }
    }
}