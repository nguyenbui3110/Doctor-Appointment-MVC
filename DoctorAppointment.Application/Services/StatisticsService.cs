using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Services;

public class StatisticsService(
    IAppointmentRepo appointmentRepo,
    IDoctorRepo doctorRepo,
    IPatientRepo patientRepo,
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser)
    : BaseService(unitOfWork, mapper, currentUser), IStatisticsService
{
    private void ValidateDateRange(DateRangeFilter filter)
    {
        if (!filter.From.HasValue || !filter.To.HasValue)
        {
            filter.From = DateTime.MinValue;
            filter.To = DateTime.MaxValue;
        }
    }

    public Dictionary<int, int> GetDailyAppointmentsCount(DateRangeFilter filter)
    {
        ValidateDateRange(filter);
        return appointmentRepo.GetDailyAppointmentsCount(filter.From.Value, filter.To.Value);
    }

    public async Task<Dictionary<DateTime, int>> GetMonthlyAppointmentsCountAsync(DateRangeFilter filter)
    {
        ValidateDateRange(filter);
        return await appointmentRepo.GetMonthlyAppointmentsCountAsync(filter.From.Value, filter.To.Value);
    }

    public async Task<Dictionary<Specialization, int>> GetSpecializationAppointmentsCountAsync(DateRangeFilter filter)
    {
        ValidateDateRange(filter);
        return await appointmentRepo.GetSpecializationAppointmentsCountAsync(filter.From.Value, filter.To.Value);
    }

    public async Task<(int NewPatient, int ReturningPatient)> GetPatientCountAsync(DateRangeFilter filter)
    {
        ValidateDateRange(filter);
        var newPatients = await appointmentRepo.GetNewPatientsCountAsync(filter.From.Value, filter.To.Value);
        var returningPatients =
            await appointmentRepo.GetReturningPatientsCountAsync(filter.From.Value, filter.To.Value);
        return (newPatients, returningPatients);
    }

    public async Task<List<KeyValuePair<string, int>>> GetTopDoctorsAsync(DateRangeFilter filter)
    {
        ValidateDateRange(filter);
        var topDoctors = await appointmentRepo.GetTop5DoctorsAsync(filter.From.Value, filter.To.Value);
        var result = new List<KeyValuePair<string, int>>();
        foreach (var doctor in topDoctors)
        {
            var name = await doctorRepo.GetDoctorNameAsync(doctor.Key);
            result.Add(new KeyValuePair<string, int>(name, doctor.Value));
        }

        return result;
    }
}