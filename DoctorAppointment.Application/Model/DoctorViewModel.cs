using System;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Model;

public class DoctorViewModel
{
    public int UserId { get; set; }
    public Specialization Specialization { get; set; }
    public int? YearsOfExperience { get; set; }
    public string? About { get; set; }

    // Optional for tracking users associated with doctors
    public User User { get; set; }
}