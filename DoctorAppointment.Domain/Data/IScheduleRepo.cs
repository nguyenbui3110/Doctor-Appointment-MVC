using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Domain.Data;

public interface IScheduleRepo : IRepository<Schedule>
{
    Task<Schedule> GetDoctorScheduleAsync(int doctorId, DayOfWeek date);
    Task<List<Schedule>> GetDoctorAllScheduleAsync(int doctorId);

}
