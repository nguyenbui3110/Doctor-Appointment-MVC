using DoctorAppointment.Application.Model;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IStatisticsService : IBaseService
{
    Dictionary<int, int> GetDailyAppointmentsCount(DateRangeFilter filter);
    Task<Dictionary<DateTime, int>> GetMonthlyAppointmentsCountAsync(DateRangeFilter filter);
    Task<List<KeyValuePair<string, int>>> GetTopDoctorsAsync(DateRangeFilter filter);
    Task<(int NewPatient, int ReturningPatient)> GetPatientCountAsync(DateRangeFilter filter);
    Task<Dictionary<Specialization, int>> GetSpecializationAppointmentsCountAsync(DateRangeFilter filter);
}