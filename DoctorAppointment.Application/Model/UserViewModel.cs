using System;
using System.ComponentModel.DataAnnotations;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Model;

public class UserViewModel
{
    [Required]
    public string FullName { get; set; } = string.Empty;
    [Required]
    public string? Address { get; set; }
    [Required]
    public DateTime? DateOfBirth { get; set; }
    public Gender? Gender { get; set; }
    [Phone]
    public string? PhoneNumber { get; set; }
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}
