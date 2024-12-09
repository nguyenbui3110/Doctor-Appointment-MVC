using System;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
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

    public Task<IEnumerable<Appointment>> GetPatientAppointmentsAsync(int patientId, DateTime date)
    {
        throw new NotImplementedException();
    }
    public async Task<Appointment?> GetAppointmentAsync(int Id)
    {
        return await DbSet.Include(a => a.Doctor.User).Include(a => a.Patient.User).Where(a =>a.Id ==Id).FirstOrDefaultAsync();
    }
}
