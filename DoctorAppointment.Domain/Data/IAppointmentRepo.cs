using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Domain.Data;

public interface IAppointmentRepo : IRepository<Appointment>
{
    Task<IEnumerable<Appointment>> GetDoctorAppointmentsAsync(int doctorId, DateTime date);

    IQueryable<Appointment> GetPatientAppointmentsQuery(int patientId, DateTime? from, DateTime? to,
        AppointmentStatus? appointmentStatus = null);

    public Task<Appointment?> GetAppointmentAsync(int id);

    IQueryable<Appointment> GetDoctorAppointmentsQuery(int doctorId, DateTime? from, DateTime? to,
        AppointmentStatus? appointmentStatus = null);

    public Task<List<Appointment>> GetAppointmentsByDateAsync(DateTime date);
    public Task<Dictionary<int, int>> GetTop5DoctorsAsync(DateTime start, DateTime end);
    public Task<Dictionary<DateTime, int>> GetMonthlyAppointmentsCountAsync(DateTime start, DateTime end);
    public Task<Dictionary<Specialization, int>> GetSpecializationAppointmentsCountAsync(DateTime start, DateTime end);
    public Dictionary<int, int> GetDailyAppointmentsCount(DateTime start, DateTime end);
    public Task<int> GetNewPatientsCountAsync(DateTime start, DateTime end);
    public Task<int> GetReturningPatientsCountAsync(DateTime start, DateTime end);
    public Task<List<Appointment>> GetAppointmentByStatusAsync(AppointmentStatus status);
    public Task<bool> CheckAppointmentAsync(int doctorId, int patientId);

}
