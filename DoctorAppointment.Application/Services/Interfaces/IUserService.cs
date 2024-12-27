using DoctorAppointment.Application.Model;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IUserService
{
    public Task<UserViewModel> GetCurrentUserAsync();
}