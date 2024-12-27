namespace DoctorAppointment.Application.Model;

public class DateRangeFilter
{
    public DateTime? From { get; set; } = DateTime.MinValue;
    public DateTime? To { get; set; } = DateTime.MaxValue;
}