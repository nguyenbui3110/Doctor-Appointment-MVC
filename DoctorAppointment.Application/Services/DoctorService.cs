using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Constants;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;
using DoctorAppointment.Domain.exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Application.Services;

public class DoctorService(
    IDoctorRepo repository,
    IScheduleRepo schedule_repo,
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser,
    UserManager<User> userManager)
    : BaseService(unitOfWork, mapper, currentUser), IDoctorService
{
    public async Task<DoctorViewModel> GetByIdAsync(int id)
    {
        var doctor = await repository.QueryGetById(id).Include(d => d.User).FirstOrDefaultAsync();
        return Mapper.Map<DoctorViewModel>(doctor);
    }

    public async Task<DoctorViewModel> GetByAdminWithIdAsync(int id)
    {
        var doctor = await repository.QueryGetById(id).Include(d => d.User).IgnoreQueryFilters().FirstOrDefaultAsync();
        return Mapper.Map<DoctorViewModel>(doctor);
    }

    public async Task<PagingItem<DoctorViewModel>> GetPagedAsync(int page, string searchQuery,
        Specialization specialization, int pageSize = 7)
    {
        var query = repository.GetByNameAndSpecialization(searchQuery, specialization);
        var doctors = repository.IgnoreQueryFilters(query).OrderBy(d => d.IsDeleted);
        var (data, count) = await repository.ApplyPaing(doctors, page, pageSize);
        return new PagingItem<DoctorViewModel>
        {
            Items = Mapper.Map<List<DoctorViewModel>>(data),
            CountPages = (int)Math.Ceiling(count / (double)pageSize),
            CurrentPage = page,
            PageSize = pageSize,
            PageUrl = i => $"?page={i}&searchQuery={searchQuery}&specialization={specialization}"
        };
    }

    public async Task<bool> AddDoctor(DoctorPostModel model)
    {
        var doctor = Mapper.Map<Doctor>(model);
        if (await userManager.FindByNameAsync(model.RegisterModel.UserName) != null)
            throw new UserNameExistException("Username already exists");
        if (await userManager.FindByEmailAsync(model.RegisterModel.Email) != null)
            throw new EmailExistException("Email already exists");
        var user = new User
        {
            UserName = model.RegisterModel.UserName,
            FullName = model.RegisterModel.FullName,
            Email = model.RegisterModel.Email
        };
        var result = await userManager.CreateAsync(user, model.RegisterModel.Password);
        if (result.Succeeded)
        {
            user = await userManager.FindByNameAsync(model.RegisterModel.UserName);
            user.EmailConfirmed = true;
            var addRoleResult = await userManager.AddToRoleAsync(user, AppRole.Doctor);
            if (!addRoleResult.Succeeded) throw new Exception("Error while adding role");
            doctor.UserId = user.Id;
            repository.Add(doctor);
            await UnitOfWork.SaveChangesAsync();
            await CreateDefaultScheduleForDoctor(doctor.Id);
            return true;
        }

        return false;
    }

    public async Task<bool> UpdateDoctor(DoctorViewModel model)
    {
        var query = repository.QueryGetById(model.Id).Include(d => d.User);
        var doctor = await repository.IgnoreQueryFilters(query).FirstOrDefaultAsync();
        if (doctor == null)
            return false;
        Mapper.Map(model, doctor);
        // repository.Update(doctor);
        await UnitOfWork.SaveChangesAsync();
        return true;
    }

    public async Task<bool> DeleteDoctor(int id)
    {
        var doctor = await repository.GetByIdAsync(id);
        if (doctor == null)
            return false;
        repository.Delete(doctor);
        await UnitOfWork.SaveChangesAsync();
        return true;
    }

    public async Task<List<DoctorViewModel>> GetByNameAndSpecialization(string name, Specialization specialization)
    {
        var doctors = await repository.GetByNameAndSpecialization(name, specialization).ToListAsync();
        return Mapper.Map<List<DoctorViewModel>>(doctors);
    }

    public async Task<List<DoctorViewModel>> GetBySpecialization(Specialization specialization)
    {
        var doctors = await repository.GetBySpecialization(specialization).ToListAsync();
        return Mapper.Map<List<DoctorViewModel>>(doctors);
    }

    public async Task<List<DoctorViewModel>> GetAll()
    {
        var doctors = await repository.GetAll().Include(d => d.User).ToListAsync();
        return Mapper.Map<List<DoctorViewModel>>(doctors);
    }

    private async Task<int> CreateDefaultScheduleForDoctor(int doctorId)
    {
        var schedules = new List<Schedule>();

        for (var i = 1; i <= 7; i++)
            schedules.Add(new Schedule
            {
                DoctorId = doctorId,
                DayOfWeek = (DayOfWeek)i,
                StartTime = TimeSpan.FromHours(8),
                EndTime = TimeSpan.FromHours(17)
            });

        await schedule_repo.AddRangeAsync(schedules);
        return await UnitOfWork.SaveChangesAsync();
    }


    public async Task RestoreDoctor(int id)
    {
        var query = repository.QueryGetById(id);
        var doctor = await repository.IgnoreQueryFilters(query).FirstOrDefaultAsync();
        if (doctor == null)
            return;
        doctor.IsDeleted = false;
        await UnitOfWork.SaveChangesAsync();
    }
}