using DoctorAppointment.Domain.Entities;
using Microsoft.Extensions.Hosting;

namespace DoctorAppointment.Application.Commons.Helpers;

public enum TemplateType
{
    AppointmentInfo,
    RemindAppointment,
    GuestCancellation,
    GuestCancellationHostNoti
}

public interface IMailTemplateHelper
{
    string GetAppointmentInfoTemplate(
        Appointment appointment);
    string GetRemindAppointmentTemplate(Appointment appointment);

    
}

public class MailTemplateHelper : IMailTemplateHelper
{
    private readonly IHostEnvironment _env;

    public MailTemplateHelper(IHostEnvironment env)
    {
        _env = env;
    }
    public string GetAppointmentInfoTemplate(Appointment appointment){
        
        var template = GetTemplate(TemplateType.AppointmentInfo)
                        .Replace("{{patient_name}}",appointment.Patient.User.FullName)
                        .Replace("{{appointment_date}}", appointment.AppointmentDate?.ToString("dd/MM/yyyy"))
                        .Replace("{{doctor_name}}",appointment.Doctor.User.FullName)
                        .Replace("{{StartTime}}",appointment.StartTime?.ToString(@"hh\:mm"))
                        .Replace("{{EndTime}}",appointment.EndTime?.ToString(@"hh\:mm"))
                        .Replace("{{notes}}","");

        return template; 
    }
    public string GetRemindAppointmentTemplate(Appointment appointment){
        var template = GetTemplate(TemplateType.RemindAppointment)
                        .Replace("{{patient_name}}",appointment.Patient.User.FullName)
                        .Replace("{{appointment_date}}", appointment.AppointmentDate?.ToString("dd/MM/yyyy"))
                        .Replace("{{doctor_name}}",appointment.Doctor.User.FullName)
                        .Replace("{{StartTime}}",appointment.StartTime?.ToString(@"hh\:mm"))
                        .Replace("{{EndTime}}",appointment.EndTime?.ToString(@"hh\:mm"))
                        .Replace("{{notes}}","");
        return template;
    }

    public string GetTemplate(TemplateType templateName)
    {
        var pathToFile = GetTemplatePath(templateName.ToString());
        
        using var reader = File.OpenText(pathToFile);
        return reader.ReadToEnd();
    }

    private string GetTemplatePath(string templateName)
    {
        return $"{_env.ContentRootPath}{Path.DirectorySeparatorChar}wwwroot{Path.DirectorySeparatorChar}MailTemplates{Path.DirectorySeparatorChar}{templateName}.html";
    }
}