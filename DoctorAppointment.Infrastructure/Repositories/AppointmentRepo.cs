using System;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;
using DoctorAppointment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Infrastructure.Repositories;

public class AppointmentRepo : RepositoryBase<Appointment>, IAppointmentRepo
{
    public AppointmentRepo(DrAppointmentDbContext dbContext) : base(dbContext)
    {
    }
    public async Task<IEnumerable<Appointment>> GetDoctorAppointmentsAsync(int doctorId, DateTime date)
    {
        return await DbSet.Where(a => a.DoctorId == doctorId && a.AppointmentDate == date).ToListAsync();
    }

    public async Task<List<Appointment>> GetPatientAppointmentsAsync(int patientId, DateTime? from, DateTime? to, AppointmentStatus? appointmentStatus = null)
    {
        var query =DbSet.Include(a => a.Doctor.User).Include(a => a.Patient.User).Where(a => a.PatientId == patientId);
        if (appointmentStatus.HasValue)
        {
            query = query.Where(a => a.Status == appointmentStatus);
        }
        if(from<to && from!=null && to!=null)
        {
            query = query.Where(a => a.AppointmentDate >= from && a.AppointmentDate <= to);
        }
        return await query.ToListAsync();
    }
    public async Task<Appointment?> GetAppointmentAsync(int Id)
    {
        return await DbSet.Include(a => a.Doctor.User).Include(a => a.Patient.User).Where(a =>a.Id ==Id).FirstOrDefaultAsync();
    }

    public async Task<List<Appointment>> GetAppointmentsByDateAsync(DateTime date)
    {
        return await DbSet.Include(a => a.Doctor.User).Include(a => a.Patient.User).Where(a=>a.AppointmentDate.Value.Date== date.Date).ToListAsync();
    }
    public async Task<List<int>> GetDailyAppointmentsCountAsync(DateTime start, DateTime end)
    {
        var appointments = await DbSet.Where(a => a.AppointmentDate >= start && a.AppointmentDate <= end)
            .GroupBy(a => a.AppointmentDate.Value.Date)
            .Select(g => g.Count())
            .ToListAsync();
        return appointments;
    }
    public async Task<List<int>> GetMonthlyAppointmentsCountAsync(DateTime start, DateTime end)
    {
        var appointments = await DbSet.Where(a => a.AppointmentDate >= start && a.AppointmentDate <= end)
            .GroupBy(a => a.AppointmentDate.Value.Month)
            .Select(g => g.Count())
            .ToListAsync();
        return appointments;
    }
    public async Task<List<int>> GetWeeklyAppointmentsCountAsync(DateTime start, DateTime end)
    {
        var appointments = await DbSet.Where(a => a.AppointmentDate >= start && a.AppointmentDate <= end)
            .GroupBy(a => EF.Functions.DateDiffWeek(start, a.AppointmentDate))
            .Select(g => g.Count())
            .ToListAsync();
        return appointments;
    }
    public async Task<Dictionary<int,int>> GetTop5DoctorsAsync(DateTime start, DateTime end)
    {
        //get top 5 doctors who have the most appointments
        var doctors = await DbSet.Where(a => a.AppointmentDate >= start && a.AppointmentDate <= end)
            .GroupBy(a => a.DoctorId)
            .Select(g => new {DoctorId = g.Key, Count = g.Count()})
            .OrderByDescending(a => a.Count)
            .Take(5)
            .ToListAsync();
        //return dictionary with doctorId as key and number of appointments as value
        return doctors.ToDictionary(a => a.DoctorId.Value, a => a.Count);
    }

}
