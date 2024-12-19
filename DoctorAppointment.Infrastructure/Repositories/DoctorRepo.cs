using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Infrastructure.Data;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Infrastructure.Repositories
{
    public class DoctorRepo : RepositoryBase<Doctor>, IDoctorRepo
    {
        public DoctorRepo(DrAppointmentDbContext dbContext) : base(dbContext)
        {
            
        }

        public IQueryable<Doctor> GetByNameAndSpecialization(string name, Specialization specialization)
        {
            var query = DbSet.Include(dr => dr.User).AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(dr => dr.User.FullName.Contains(name));
            }

            if (specialization != 0)
            {
                query = query.Where(dr => dr.Specialization == specialization);
            }

            return query;
        }

        public IQueryable<Doctor> GetBySpecialization(Specialization specialization)
        {
            return DbSet
                    .Include(dr => dr.User)
                    .Where(dr => dr.Specialization == specialization);
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
    }
}
