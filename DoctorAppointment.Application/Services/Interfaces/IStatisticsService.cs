using System;
using DoctorAppointment.Application.Model;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IStatisticsService: IBaseService
{
    Task<StatisticsViewModel> GetStatisticsAsync(DateTime startDate, DateTime endDate);
}
