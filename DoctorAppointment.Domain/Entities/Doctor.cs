using System;
using DoctorAppointment.Domain.Entities.Base;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Domain.Entities;

public class Doctor:EntityBase
{

    public int UserId { get; set; }
    public Specialization Specialization { get; set; }
    public int? YearsOfExperience { get; set; }
    public string? About { get; set; }
    public ICollection<Appointment> Appointments { get; set; }

    // Optional for tracking users associated with doctors
    public User User { get; set; }
    public ICollection<Schedule> Schedules { get; set; }
}
