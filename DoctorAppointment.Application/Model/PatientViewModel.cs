using DoctorAppointment.Domain.Entities;
using System;
using System.Collections.Generic;

namespace DoctorAppointment.Application.Model
{
    public class PatientViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }

        public UserViewModel User { get; set; }
    }
}
