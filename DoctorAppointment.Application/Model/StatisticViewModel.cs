using System;

namespace DoctorAppointment.Application.Model;

public class StatisticsViewModel
{
    public List<int> DailyAppointments { get; set; }
    public List<int> WeeklyAppointments { get; set; }
    public List<int> MonthlyAppointments { get; set; }
    public int NewPatientsCount { get; set; }
    public int ReturningPatientsCount { get; set; }
    public Dictionary<string,int> TopDoctor { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}
