using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Application.Services
{
    public class PatientService(IPatientRepo repository, IUnitOfWork unitOfWork,
                                IMapper mapper, ICurrentUser currentUser,
                                UserManager<User> userManager)
                                : BaseService(unitOfWork, mapper, currentUser), IPatientService
    {
        public async Task<PagingItem<PatientViewModel>> GetPagedAsync(int page, string searchQuery,int pageSize = 8)
        {
            var patients = repository.Search(searchQuery);

            (var data, var Count) = await repository.ApplyPaing(patients, page, pageSize);
            return new PagingItem<PatientViewModel>
            {
                Items = Mapper.Map<List<PatientViewModel>>(data),
                CountPages = (int)Math.Ceiling(Count / (double)pageSize),
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
    }
}
