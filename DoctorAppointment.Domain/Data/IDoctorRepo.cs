using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Domain.Data
{
    public interface IDoctorRepo: IRepository<Doctor>
    {
        IQueryable<Doctor> GetByNameAndSpecialization(string name, Specialization specialization);
        IQueryable<Doctor> GetBySpecialization(Specialization specialization);
    }
}
