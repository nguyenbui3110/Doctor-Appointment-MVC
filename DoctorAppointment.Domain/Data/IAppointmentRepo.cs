using System;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Domain.Data;

public interface IAppointmentRepo: IRepository<Appointment>
{
    Task<IEnumerable<Appointment>> GetDoctorAppointmentsAsync(int doctorId, DateTime date);
    Task<List<Appointment>> GetPatientAppointmentsAsync(int patientId, DateTime? from, DateTime? to, AppointmentStatus? appointmentStatus = null);
    public Task<Appointment?> GetAppointmentAsync(int Id);
    public Task<List<Appointment>> GetAppointmentsByDateAsync(DateTime date);
}
