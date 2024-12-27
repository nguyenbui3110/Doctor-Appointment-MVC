using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Infrastructure.Repositories;

public class ScheduleRepo : RepositoryBase<Schedule>, IScheduleRepo
{
    public ScheduleRepo(DrAppointmentDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<List<Schedule>> GetDoctorAllScheduleAsync(int doctorId)
    {
        var schedules = await DbSet.Where(sc => sc.DoctorId == doctorId).ToListAsync();
        return schedules;
    }

    public async Task<Schedule?> GetDoctorScheduleAsync(int doctorId, DayOfWeek date)
    {
        var schedule = DbSet.Where(sc => sc.DoctorId == doctorId && sc.DayOfWeek == date);
        Console.WriteLine(schedule);
        return schedule.FirstOrDefault();
    }
}