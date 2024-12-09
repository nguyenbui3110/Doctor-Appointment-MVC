using System;
using System.ComponentModel.DataAnnotations;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Model;

public class DoctorViewModel
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public Specialization Specialization { get; set; }
    public int? YearsOfExperience { get; set; }
    public string? About { get; set; }

    // Optional for tracking users associated with doctors
    public UserViewModel User { get; set; }
}
