using System;
using DoctorAppointment.Application.Model;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IDoctorService
{
    Task<DoctorViewModel> GetByIdAsync(int id);
}
