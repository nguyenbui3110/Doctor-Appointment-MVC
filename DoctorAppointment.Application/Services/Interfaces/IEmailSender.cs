
namespace DoctorAppointment.Application.Services.Interfaces;

public interface IEmailSender
{
    Task SendEmailAsync(Message message);
}
