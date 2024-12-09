using System;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Domain.Data;

public interface IAppointmentRepo: IRepository<Appointment>
{
    Task<IEnumerable<Appointment>> GetDoctorAppointmentsAsync(int doctorId, DateTime date);
    Task<IEnumerable<Appointment>> GetPatientAppointmentsAsync(int patientId, DateTime date);
}
