using System;
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
    public async Task<Schedule?> GetDoctorScheduleAsync(int doctorId, DayOfWeek date)
    {
        var Schedule =  DbSet.Where(sc => sc.DoctorId == doctorId && sc.DayOfWeek == date);
        Console.WriteLine(Schedule);
        return Schedule.FirstOrDefault();
    }
}
