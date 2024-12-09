using System;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IAppointmentService : IBaseService
{
    Task<Appointment> GetDoctorAppointmentsAsync(int doctorId, DateTime date);
    Task<Appointment> GetPatientAppointmentsAsync(int patientId, DateTime date);
    //Get free time slot on a specific date
    Task<IEnumerable<TimeSpan>> GetFreeTimeSlotsAsync(int doctorId, DateTime date);


}
