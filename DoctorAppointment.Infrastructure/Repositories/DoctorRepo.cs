﻿using DoctorAppointment.Domain.Entities;
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
    }
}