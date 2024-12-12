using System;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IDoctorService : IBaseService
{
    Task<DoctorViewModel> GetByIdAsync(int id);
    Task<List<DoctorViewModel>> GetBySpecialization(Specialization specialization);

    Task<PagingItem<DoctorViewModel>> GetPagedAsync(int page,string SearchQuery, Specialization specialization, int pageSize = 8);
    Task<bool> AddDoctor(DoctorPostModel model);
    Task<bool> UpdateDoctor(DoctorViewModel model);
    Task<bool> DeleteDoctor(int id);
    Task<List<DoctorViewModel>> GetByNameAndSpecialization(string name, Specialization specialization);
    Task<List<DoctorViewModel>> GetAll();

}
