using System;
using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Application.Services;

public class ScheduleService(IScheduleRepo scheduleRepo, IUnitOfWork unitOfWork, IMapper mapper, ICurrentUser currentUser)
    : BaseService(unitOfWork, mapper, currentUser), IScheduleService
{
    public async Task<Schedule> GetDoctorScheduleAsync(int doctorId, DayOfWeek date)
    {
        return await scheduleRepo.GetDoctorScheduleAsync(doctorId, date);
    }
}
