using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Infrastructure.Repositories
{
    public class PatientRepo : RepositoryBase<Patient>, IPatientRepo
    {
        public PatientRepo(DrAppointmentDbContext dbContext) : base(dbContext)
        {
        }
    }
}
