using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Model;

public class AppointmentViewModel
{
    public int Id { get; set; }

    public DateTime? AppointmentDate { get; set; }
    public TimeSpan? StartTime { get; set; }
    public TimeSpan? EndTime { get; set; }
    public int DoctorId { get; set; }
    public string? DoctorName { get; set; }
    public int PatientId { get; set; }
    public string? PatientName { get; set; }
    public AppointmentStatus? Status { get; set; }
    public string? Notes { get; set; }
}