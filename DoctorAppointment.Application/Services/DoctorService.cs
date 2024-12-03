using System;
using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Application.Services;

public class DoctorService(IRepository<Doctor> repository, IUnitOfWork unitOfWork, IMapper mapper, ICurrentUser currentUser) :BaseService(unitOfWork, mapper, currentUser),IDoctorService
{
    public async Task<DoctorViewModel> GetByIdAsync(int id)
    {
        var doctor = await repository.GetByIdAsync(id);
        return Mapper.Map<DoctorViewModel>(doctor);
    }

}
