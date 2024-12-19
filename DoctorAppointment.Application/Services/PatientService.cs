using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Application.Services
{
    public class PatientService(IPatientRepo repository, IUnitOfWork unitOfWork,
                                IMapper mapper, ICurrentUser currentUser,
                                UserManager<User> userManager)
                                : BaseService(unitOfWork, mapper, currentUser), IPatientService
    {
        public async Task<PagingItem<PatientViewModel>> GetPagedAsync(int page, string searchQuery,int pageSize = 8)
        {
            var query = repository.Search(searchQuery);
            var patients= repository.IgnoreQueryFilters(query).OrderBy(d=>d.IsDeleted);

            (var data, var count) = await repository.ApplyPaing(patients, page, pageSize);
            return new PagingItem<PatientViewModel>
            {
                Items = Mapper.Map<List<PatientViewModel>>(data),
                CountPages = (int)Math.Ceiling(count / (double)pageSize),
                CurrentPage = page,
                PageSize = pageSize,
                PageUrl = i => $"?page={i}&searchQuery={searchQuery}"
            };
        }

        public async Task<bool> DeletePatient(int id)
        {
            var patient = await repository.GetByIdAsync(id);
            if (patient == null)
                return false;
            repository.Delete(patient);
            await UnitOfWork.SaveChangesAsync();
            return true;
        }
        public async Task<bool> RestorePatient(int id)
        {
            var query = repository.QueryGetById(id);
            var patient = await repository.IgnoreQueryFilters(query).FirstOrDefaultAsync();
            if (patient == null)
                return false;
            patient.IsDeleted = false;
            await UnitOfWork.SaveChangesAsync();
            return true;
        }
    }
}
