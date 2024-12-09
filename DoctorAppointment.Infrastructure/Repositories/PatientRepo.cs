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
    }
}
