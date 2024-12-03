using System;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IDoctorService
{
    Task<DoctorViewModel> GetByIdAsync(int id);
    Task<List<DoctorViewModel>> GetBySpecialization(Specialization specialization);

}
