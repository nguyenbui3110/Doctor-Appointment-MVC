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
}
