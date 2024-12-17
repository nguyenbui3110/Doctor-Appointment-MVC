using Bogus.DataSets;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Infrastructure.Repositories
{
    public class PatientRepo : RepositoryBase<Patient>, IPatientRepo
    {
        public PatientRepo(DrAppointmentDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Patient?> GetPatientByUserIdAsync(int id)
        {
            return await DbSet.Where(x => x.UserId == id)
                .FirstOrDefaultAsync();
        }
        public IQueryable<Patient> Search(string searchQuery)
        {
            var patients = DbSet.Include(dr => dr.User).AsQueryable();
            if (!string.IsNullOrEmpty(searchQuery))
            {
                patients = patients.Where(dr => dr.User.FullName.Contains(searchQuery));
            }
            return patients;
        }
        public async Task<int> GetNewPatientsCountAsync(DateTime start, DateTime end)
        {
            return await DbSet
                .Include(p => p.Appointments)  // Include the appointments for each patient
                .Where(p => p.Appointments.Any(a => a.CreatedAt >= start && a.CreatedAt <= end))  // Appointment within the range
                .Where(p => !p.Appointments.Any(a => a.CreatedAt < start))  // No previous appointments before the start date
                .CountAsync();
        }

        public async Task<int> GetReturningPatientsCountAsync(DateTime start, DateTime end)
        {
            return await DbSet.Include(p => p.Appointments)  // Include the appointments for each patient
                .Where(p => p.Appointments.Any(a => a.CreatedAt >= start && a.CreatedAt <= end))  // Appointment within the range
                .Where(p => p.Appointments.Any(a => a.CreatedAt < start))  // At least one previous appointment before the start date
                .CountAsync();
        }

    }
}
