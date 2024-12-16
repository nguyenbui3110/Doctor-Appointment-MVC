using System;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Model;

public class AppointmentSearchModel
{
    public DateTime? From { get; set; }
    public DateTime? To { get; set; }
    public AppointmentStatus? Status { get; set; }
}
