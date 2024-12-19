using DoctorAppointment.Application.Model;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IStatisticsService: IBaseService
{
    Dictionary<int,int> GetDailyAppointmentsCount(DateRangeFilter filter);
    Task<Dictionary<DateTime,int>> GetMonthlyAppointmentsCountAsync(DateRangeFilter filter);
    Task<Dictionary<string,int>> GetTopDoctorsAsync(DateRangeFilter filter);
    Task<(int NewPatient ,int ReturningPatient)> GetPatientCountAsync(DateRangeFilter filter);
}
