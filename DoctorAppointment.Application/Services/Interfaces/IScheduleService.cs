using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IScheduleService : IBaseService
{
    Task<Schedule> GetDoctorScheduleAsync(int doctorId, DayOfWeek date);
}
