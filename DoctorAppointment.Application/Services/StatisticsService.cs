using System;
using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;

namespace DoctorAppointment.Application.Services;

public class StatisticsService(IAppointmentRepo appointmentRepo, IDoctorRepo doctorRepo,
                                IPatientRepo patientRepo, IUnitOfWork unitOfWork,
                                IMapper mapper, ICurrentUser currentUser)
                                : BaseService(unitOfWork, mapper, currentUser), IStatisticsService
{
    public  Dictionary<int,int> GetDailyAppointmentsCount(DateRangeFilter filter)
    {
        return appointmentRepo.GetDailyAppointmentsCount(filter.From.Value, filter.To.Value);
    }

    public async Task<Dictionary<int,int>> GetMonthlyAppointmentsCountAsync(DateRangeFilter filter)
    {
        return await appointmentRepo.GetMonthlyAppointmentsCountAsync(filter.From.Value, filter.To.Value);
    }

    public async Task<(int NewPatient, int ReturningPatient)> GetPatientCountAsync(DateRangeFilter filter)
    {
        var newPatients = await appointmentRepo.GetNewPatientsCountAsync(filter.From.Value, filter.To.Value);
        var returningPatients = await appointmentRepo.GetReturningPatientsCountAsync(filter.From.Value, filter.To.Value);
        return (newPatients,returningPatients);
    }

    public async Task<Dictionary<string, int>> GetTopDoctorsAsync(DateRangeFilter filter)
    {            
        var topDoctors = await appointmentRepo.GetTop5DoctorsAsync(filter.From.Value, filter.To.Value);
        var result = new Dictionary<string, int>();
        foreach (var doctor in topDoctors)
        {
            var name = await doctorRepo.GetDoctorNameAsync(doctor.Key);
            result.Add(name, doctor.Value);
        }
        return result;
    }
}
