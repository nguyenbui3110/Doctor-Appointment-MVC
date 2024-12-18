using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Model;

public class DoctorPostModel
{
    public int UserId { get; set; }
    public Specialization Specialization { get; set; }
    public int? YearsOfExperience { get; set; }
    public string? About { get; set; }

    // Optional for tracking users associated with doctors
    public RegisterModel RegisterModel { get; set; }
}
