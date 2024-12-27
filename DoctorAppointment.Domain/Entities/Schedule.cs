using DoctorAppointment.Domain.Entities.Base;

namespace DoctorAppointment.Domain.Entities;

public class Schedule : EntityBase
{
    public Doctor Doctor { get; set; }
    public int DoctorId { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public DayOfWeek DayOfWeek { get; set; }
}