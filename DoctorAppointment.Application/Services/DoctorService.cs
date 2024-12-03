using System;
using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Application.Services;

public class DoctorService(IDoctorRepo repository, IUnitOfWork unitOfWork, IMapper mapper, ICurrentUser currentUser) 
    :BaseService(unitOfWork, mapper, currentUser), IDoctorService
{
    public async Task<DoctorViewModel> GetByIdAsync(int id)
    {
        var doctor = await repository.GetByIdAsync(id);
        return Mapper.Map<DoctorViewModel>(doctor);
    }

    public async Task<List<DoctorViewModel>> GetBySpecialization(Specialization specialization)
    {
        var doctors = await repository.GetBySpecialization(specialization).ToListAsync();
        return Mapper.Map<List<DoctorViewModel>>(doctors);
    }
}
