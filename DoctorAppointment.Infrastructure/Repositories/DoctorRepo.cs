using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Infrastructure.Data;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Infrastructure.Repositories;

public class DoctorRepo : RepositoryBase<Doctor>, IDoctorRepo
{
    public DoctorRepo(DrAppointmentDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Doctor?> GetDoctorByUserIdAsync(int id)
    {
        return await DbSet.Where(x => x.UserId == id)
            .Include(x => x.Schedules)
            .FirstOrDefaultAsync();
    }

    public IQueryable<Doctor> GetByNameAndSpecialization(string name, Specialization specialization)
    {
        var query = DbSet.Include(dr => dr.User).AsQueryable();

        if (!string.IsNullOrEmpty(name)) query = query.Where(dr => dr.User.FullName.Contains(name));

        if (specialization != 0) query = query.Where(dr => dr.Specialization == specialization);

        return query;
    }

    public IQueryable<Doctor> GetBySpecialization(Specialization specialization)
    {
        return DbSet
            .Include(dr => dr.User)
            .Where(dr => dr.Specialization == specialization);
    }

    public void CreateDefaultScheduleForDoctor(int doctorId)
    {
        var schedules = new List<Schedule>();
        var id = 1;

        for (var i = 1; i <= 7; i++)
            schedules.Add(new Schedule
            {
                Id = id++,
                DoctorId = doctorId,
                DayOfWeek = (DayOfWeek)i,
                StartTime = TimeSpan.FromHours(8),
                EndTime = TimeSpan.FromHours(17)
            });
    }

    public async Task<string?> GetDoctorNameAsync(int doctorId)
    {
        return await DbSet
            .IgnoreQueryFilters()
            .Include(dr => dr.User)
            .Where(dr => dr.Id == doctorId)
            .Select(dr => dr.User.FullName)
            .FirstOrDefaultAsync();
    }

    public async Task<Doctor> UpdateDoctorAllScheduleAsync(Doctor doctor, List<Schedule> schedule)
    {
        var index = 0;
        foreach (var currentSchedule in doctor.Schedules)
        {
            currentSchedule.StartTime = schedule[index].StartTime;
            currentSchedule.EndTime = schedule[index].EndTime;
            index++;
        }

        return doctor;
    }
}