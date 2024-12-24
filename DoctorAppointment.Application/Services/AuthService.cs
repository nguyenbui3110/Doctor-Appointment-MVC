
namespace DoctorAppointment.Application.Services;

using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.exceptions;
using Microsoft.AspNetCore.Identity;

public class AuthService(SignInManager<User> signInManager, UserManager<User> userManager,
                        IUnitOfWork unitOfWork,IMapper mapper,
                        ICurrentUser currentUser,IRepository<Patient> patientRepo,
                        IEmailSender emailSender)
                        : BaseService(unitOfWork, mapper, currentUser)
{


    public Task<User> GetUserAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> LoginAsync(LoginModel model)
    {
        var user = await userManager.FindByEmailAsync(model.Email);
        if (user == null) return false;
        var result = await signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);
        if (!result.Succeeded)
        {
            // throw new Exception("Invalid login attempt");
            return false;
        }
        return true;
    }

    public async Task LogoutAsync()
    {
        await signInManager.SignOutAsync();
    }


    public async Task<bool> RegisterAsync(RegisterModel model)
    {
        if (await userManager.FindByNameAsync(model.UserName) != null)
        {
            throw new UserNameExistException("Username already exists");
        }
        if (await userManager.FindByEmailAsync(model.Email) != null)
        {
            throw new EmailExistException("Email already exists");
        }
        var user = new User
        {
            UserName = model.UserName,
            FullName = model.FullName,
            Email = model.Email
        };
        var result = await userManager.CreateAsync(user, model.Password);
        if (result.Succeeded)
        {
            user = await userManager.FindByNameAsync(model.UserName);
            user.EmailConfirmed = true;
            patientRepo.Add( new Patient{UserId=user.Id});
            await UnitOfWork.SaveChangesAsync();
            await signInManager.SignInAsync(user, false);
            return true;
        }

        return false;
    }
    public async Task<string> ForgetPasswordAsync(string email)
    {
        var user = await userManager.FindByEmailAsync(email);
        if (user == null) throw new EmailNotExistException("Email not exist");
        return await userManager.GeneratePasswordResetTokenAsync(user);       
    }
    public async Task<bool> ResetPasswordAsync(ResetPasswordModel model)
    {
        var user = await userManager.FindByEmailAsync(model.Email);
        if (user == null) throw new EmailNotExistException("Email not exist");
        var result = await userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
        return result.Succeeded;
    }
}
