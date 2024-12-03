using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public IQueryable<Doctor> GetBySpecialization(Specialization specialization)
        {
            return DbSet.Where(dr => dr.Specialization == specialization);
        }
    }
}
