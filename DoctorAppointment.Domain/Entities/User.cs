using DoctorAppointment.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace DoctorAppointment.Domain.Entities;

public class User : IdentityUser<int>
{
    public string FullName { get; set; } = string.Empty;
    public string? Address { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? Country { get; set; }
    public string? AvatarUrl { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public Gender? Gender { get; set; }
    public Doctor? Doctor { get; set; }
    public Patient? Patient { get; set; }
    
}
