using System;

namespace DoctorAppointment.Application.Model;

public class AppointmentPostModel
{
    public int? DoctorId { get; set; }
    public DateTime? AppointmentDate { get; set; }
    public TimeSpan? StartTime { get; set; }
    public TimeSpan? EndTime { get; set; }
}
