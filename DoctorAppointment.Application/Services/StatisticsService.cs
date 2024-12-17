using System;
using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;

namespace DoctorAppointment.Application.Services;

public class StatisticsService( IAppointmentRepo appointmentRepo,IDoctorRepo doctorRepo,
                                IPatientRepo patientRepo,IUnitOfWork unitOfWork,
                                IMapper mapper, ICurrentUser currentUser)
                                : BaseService(unitOfWork, mapper, currentUser) , IStatisticsService
{
    public Task<StatisticsViewModel> GetStatisticsAsync(DateTime startDate, DateTime endDate)
    {
        return Task.FromResult(new StatisticsViewModel());
    }
}
