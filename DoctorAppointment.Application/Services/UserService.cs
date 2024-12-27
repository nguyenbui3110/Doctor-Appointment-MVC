using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace DoctorAppointment.Application.Services;

public class UserService(
    UserManager<User> userManager,
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser)
    : BaseService(unitOfWork, mapper, currentUser), IUserService
{
    public async Task<UserViewModel> GetCurrentUserAsync()
    {
        var user = await userManager.FindByIdAsync(CurrentUser.Id);
        return Mapper.Map<UserViewModel>(user);
    }

    public async Task<bool> UpdateUserAsync(UserViewModel model)
    {
        var user = await userManager.FindByIdAsync(CurrentUser.Id);
        user = Mapper.Map(model, user);
        var result = await userManager.UpdateAsync(user);
        return result.Succeeded;
    }
}