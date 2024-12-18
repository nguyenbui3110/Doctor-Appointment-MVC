using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Infrastructure.Data;

namespace DoctorAppointment.Infrastructure.Repositories;

public class ScheduleRepo : RepositoryBase<Schedule>, IScheduleRepo
{
    public ScheduleRepo(DrAppointmentDbContext dbContext) : base(dbContext)
    {
    }
    public async Task<Schedule?> GetDoctorScheduleAsync(int doctorId, DayOfWeek date)
    {
        var schedule =  DbSet.Where(sc => sc.DoctorId == doctorId && sc.DayOfWeek == date);
        Console.WriteLine(schedule);
        return schedule.FirstOrDefault();
    }
}
