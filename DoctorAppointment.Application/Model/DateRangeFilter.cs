namespace DoctorAppointment.Application.Model;

public class DateRangeFilter
{
    public DateTime? From { get; set; } = DateTime.Now.AddYears(-1);
    public DateTime? To { get; set; } = DateTime.Now;
}