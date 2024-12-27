using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Application.Services;

public class ScheduleService(IScheduleRepo scheduleRepo,IDoctorRepo doctorRepo ,IUnitOfWork unitOfWork, IMapper mapper, ICurrentUser currentUser)
    : BaseService(unitOfWork, mapper, currentUser), IScheduleService
{

    public async Task<Schedule> GetDoctorScheduleAsync(int doctorId, DayOfWeek date)
    {
        return await scheduleRepo.GetDoctorScheduleAsync(doctorId, date);
    }

    public async Task<List<Schedule>> GetDotorAllScheduleAsync()
    {
        var curentId = int.Parse(CurrentUser.Id);
        var doctor = await doctorRepo.GetDoctorByUserIdAsync(curentId);
        return doctor.Schedules.ToList();
    }

    public async Task<List<Schedule>> UpdateDoctorAllScheduleAsync(List<Schedule> schedule)
    {
        var curentId = int.Parse(CurrentUser.Id);
        var doctor = await doctorRepo.GetDoctorByUserIdAsync(curentId);
        var doctorNewSchedule = await doctorRepo.UpdateDoctorAllScheduleAsync(doctor, schedule);
        await UnitOfWork.SaveChangesAsync();
        return doctorNewSchedule.Schedules.ToList();
    }
}
