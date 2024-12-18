using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Constants;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Application.Services;

public class DoctorService(IDoctorRepo repository, IUnitOfWork unitOfWork,
                            IMapper mapper, ICurrentUser currentUser,
                            UserManager<User> userManager)
                            : BaseService(unitOfWork, mapper, currentUser), IDoctorService
{
    public async Task<DoctorViewModel> GetByIdAsync(int id)
    {
        var doctor = await repository.QueryGetById(id).Include(d=>d.User).FirstOrDefaultAsync();
        return Mapper.Map<DoctorViewModel>(doctor);
    }

    public async Task<PagingItem<DoctorViewModel>> GetPagedAsync(int page, string searchQuery, Specialization specialization, int pageSize = 8)
    {
        var doctors = repository.GetByNameAndSpecialization(searchQuery, specialization).IgnoreQueryFilters().OrderBy(d=>d.IsDeleted);
        (var data, var count) = await repository.ApplyPaing(doctors, page, pageSize);
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
            if (!addRoleResult.Succeeded)
                {
                    throw new Exception("Error while adding role");
                    
                }
            doctor.UserId = user.Id;
            repository.Add(doctor);
            await UnitOfWork.SaveChangesAsync();
            return true;
        }
        return false;

    }

    public async Task<bool> UpdateDoctor(DoctorViewModel model)
    {
        var doctor = await repository.QueryGetById(model.Id).Include(d=>d.User).FirstOrDefaultAsync();
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
        var doctors= await repository.GetAll().Include(d=>d.User).ToListAsync();
        return Mapper.Map<List<DoctorViewModel>>(doctors);
    }
}
