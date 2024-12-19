using System.ComponentModel.DataAnnotations;
using System.Reflection;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.WebApp.Commons.Helpers;

public static class GetSpecializationDisplayName
{
    public static string Get(Specialization specialization)
    {
        var memberInfo = typeof(Specialization).GetMember(specialization.ToString())[0];
        var displayAttribute = memberInfo.GetCustomAttribute<DisplayAttribute>();
        var displayName = displayAttribute?.Name ?? specialization.ToString();
        return displayName;
    }
}
