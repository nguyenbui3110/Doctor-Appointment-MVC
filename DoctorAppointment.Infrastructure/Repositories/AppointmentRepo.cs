﻿using DoctorAppointment.Domain.Data;
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
        return await DbSet.Where(a => a.DoctorId == doctorId && a.AppointmentDate == date
                                                             && a.Status != AppointmentStatus.Cancelled
                                                             && a.Status != AppointmentStatus.Rejected).ToListAsync();
    }

    public IQueryable<Appointment> GetPatientAppointmentsQuery(int patientId, DateTime? from, DateTime? to,
        AppointmentStatus? appointmentStatus = null)
    {
        var query = DbSet
            .IgnoreQueryFilters()
            .Include(a => a.Doctor.User)
            .Include(a => a.Patient.User)
            .Where(a => a.PatientId == patientId);
        if (appointmentStatus.HasValue) query = query.Where(a => a.Status == appointmentStatus);
        if (from < to && from != null && to != null)
            query = query.Where(a => a.AppointmentDate >= from && a.AppointmentDate <= to);
        return query;
    }

    public async Task<Appointment?> GetAppointmentAsync(int id)
    {
        return await DbSet.Include(a => a.Doctor.User).Include(a => a.Patient.User).Where(a => a.Id == id)
            .FirstOrDefaultAsync();
    }

    public async Task<List<Appointment>> GetAppointmentsByDateAsync(DateTime date)
    {
        return await DbSet.Include(a => a.Doctor.User).Include(a => a.Patient.User)
            .Where(a => a.AppointmentDate.Value.Date == date.Date).ToListAsync();
    }

    public Dictionary<int, int> GetDailyAppointmentsCount(DateTime start, DateTime end)
    {
        var appointments = DbSet
            .IgnoreQueryFilters()
            .Where(a => a.AppointmentDate >= start && a.AppointmentDate <= end &&
                        a.Status == AppointmentStatus.Completed) // Appointments in the date range
            .AsEnumerable()
            .GroupBy(a => (int)a.AppointmentDate.Value.DayOfWeek) // Project as integer
            .ToDictionary(g => g.Key, g => g.Count());

        var allDays = Enumerable.Range(0, 7); // 0 = Sunday, 1 = Monday, ..., 6 = Saturday
        var result = allDays
            .ToDictionary(
                day => day,
                day => appointments.ContainsKey(day) ? appointments[day] : 0
            )
            .OrderBy(kv => kv.Key) // Order by month (key)
            .ToDictionary(kv => kv.Key, kv => kv.Value);

        return result;
    }

    public async Task<Dictionary<DateTime, int>> GetMonthlyAppointmentsCountAsync(DateTime start, DateTime end)
    {
        var appointments = await DbSet
            .IgnoreQueryFilters()
            .Where(a => a.AppointmentDate >= start && a.AppointmentDate <= end &&
                        a.Status == AppointmentStatus.Completed) // Appointments in the date range
            .GroupBy(a => new DateTime(a.AppointmentDate.Value.Year, a.AppointmentDate.Value.Month, 1))
            .ToDictionaryAsync(g => g.Key, g => g.Count());

        var allMonths = Enumerable.Range(0, (end.Year - start.Year) * 12 + end.Month - start.Month + 1)
            .Select(offset => new DateTime(start.Year, start.Month, 1).AddMonths(offset));

        var result = allMonths
            .ToDictionary(
                month => month,
                month => appointments.ContainsKey(month) ? appointments[month] : 0
            )
            .OrderBy(kv => kv.Key) // Order by month (key)
            .ToDictionary(kv => kv.Key, kv => kv.Value);

        return result;
    }
    public async Task<Dictionary<Specialization, int>> GetSpecializationAppointmentsCountAsync(DateTime start, DateTime end)
    {
        var appointments = await DbSet
            .Include(a => a.Doctor)
            .IgnoreQueryFilters()
            .Where(a => a.AppointmentDate >= start && a.AppointmentDate <= end &&
                        a.Status == AppointmentStatus.Completed)
            .GroupBy(a => a.Doctor.Specialization)
            .Select(g => new
            {
                Specialization = g.Key,
                Count = g.Count()
            })
            .ToListAsync();
        return appointments
            .OrderBy(a => a.Specialization.ToString())
            .ToDictionary(
                g => g.Specialization,
                g => g.Count
            );
    }

    public async Task<Dictionary<int, int>> GetTop5DoctorsAsync(DateTime start, DateTime end)
    {
        //get top 5 doctors who have the most appointments
        var doctors = await DbSet
            .IgnoreQueryFilters()
            .Where(a => a.AppointmentDate >= start && a.AppointmentDate <= end &&
                        a.Status == AppointmentStatus.Completed) // Appointments in the date range
            .GroupBy(a => a.DoctorId)
            .Select(g => new { DoctorId = g.Key, Count = g.Count() })
            .OrderByDescending(a => a.Count)
            .Take(5)
            .ToListAsync();
        //return dictionary with doctorId as key and number of appointments as value
        return doctors.ToDictionary(a => a.DoctorId.Value, a => a.Count);
    }

    public Task<int> GetNewPatientsCountAsync(DateTime start, DateTime end)
    {
        return DbSet
            .IgnoreQueryFilters()
            .Where(a => a.AppointmentDate >= start && a.AppointmentDate <= end &&
                        a.Status == AppointmentStatus.Completed) // Appointments in the date range
            .GroupBy(a => a.PatientId)
            .Where(g =>
                g.Count() == 1 &&
                !DbSet.Any(b =>
                    b.PatientId == g.Key && b.AppointmentDate < start && b.Status == AppointmentStatus.Completed)
            )
            .CountAsync();
    }


    public Task<int> GetReturningPatientsCountAsync(DateTime start, DateTime end)
    {
        return DbSet
            .IgnoreQueryFilters()
            .Where(a => a.AppointmentDate >= start && a.AppointmentDate <= end &&
                        a.Status == AppointmentStatus.Completed) // Appointments in the date range
            .GroupBy(a => a.PatientId)
            .Where(g =>
                    g.Count() > 1 || // More than 1 appointment in date range
                    DbSet.Any(b =>
                        b.PatientId == g.Key && b.AppointmentDate < start &&
                        b.Status == AppointmentStatus.Completed) // Or has prior appointments
            )
            .CountAsync(); // Count the number of such patients
    }

    public async Task<List<Appointment>> GetAppointmentByStatusAsync(AppointmentStatus status)
    {
        return await DbSet
            // .Include(a => a.Doctor.User)
            // .Include(a => a.Patient.User)
            .Where(a => a.Status == status).ToListAsync();
    }

    public async Task<List<Appointment>> GetDoctorAppointmentsAsync(int doctorId, DateTime? from, DateTime? to,
        AppointmentStatus? appointmentStatus = null)
    {
        var query = DbSet.Include(a => a.Doctor.User).Include(a => a.Patient.User).Where(a => a.DoctorId == doctorId);
        if (appointmentStatus.HasValue) query = query.Where(a => a.Status == appointmentStatus);
        if (from < to && from != null && to != null)
            query = query.Where(a => a.AppointmentDate >= from && a.AppointmentDate <= to);
        return await query.ToListAsync();
    }

    public IQueryable<Appointment> GetDoctorAppointmentsQuery(int doctorId, DateTime? from, DateTime? to,
        AppointmentStatus? appointmentStatus = null)
    {
        var query = DbSet
            .IgnoreQueryFilters()
            .Include(a => a.Doctor.User)
            .Include(a => a.Patient.User)
            .Where(a => a.DoctorId == doctorId);
        if (appointmentStatus.HasValue) query = query.Where(a => a.Status == appointmentStatus);
        if (from < to && from != null && to != null)
            query = query.Where(a => a.AppointmentDate >= from && a.AppointmentDate <= to);
        return query;
    }

    public async Task<bool> CheckAppointmentAsync(int doctorId, int patientId)
    {
        var hasAppointment = await DbSet.AnyAsync(a => a.DoctorId == doctorId && a.PatientId == patientId && a.Status == AppointmentStatus.Completed);
        return hasAppointment;
    }
}