using System;
using DoctorAppointment.Domain.Entities.Base;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Domain.Entities;

public class Appointment: EntityBase
{
    public int? DoctorId { get; set; }
    public Doctor? Doctor { get; set; }

    public int? PatientId { get; set; }
    public Patient? Patient { get; set; }

    public DateTime? AppointmentDate { get; set; }
    public AppointmentStatus? Status { get; set; } // Enum property
}
