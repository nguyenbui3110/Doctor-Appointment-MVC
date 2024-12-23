using System.ComponentModel.DataAnnotations;
using System.Reflection;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.WebApp.Commons.Helpers;

public static class DisplayName
{
    public static string GetSpecialization(Specialization specialization)
    {
        var memberInfo = typeof(Specialization).GetMember(specialization.ToString())[0];
        var displayAttribute = memberInfo.GetCustomAttribute<DisplayAttribute>();
        var displayName = displayAttribute?.Name ?? specialization.ToString();
        return displayName;
    }
    public static string GetAppointmentStatus(AppointmentStatus appointmentStatus)
    {
        var memberInfo = typeof(AppointmentStatus).GetMember(appointmentStatus.ToString())[0];
        var displayAttribute = memberInfo.GetCustomAttribute<DisplayAttribute>();
        var displayName = displayAttribute?.Name ?? appointmentStatus.ToString();
        return displayName;
    }
}
