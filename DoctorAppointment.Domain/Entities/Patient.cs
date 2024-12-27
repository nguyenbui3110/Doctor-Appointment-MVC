using DoctorAppointment.Domain.Entities.Base;

namespace DoctorAppointment.Domain.Entities;

public class Patient : EntityBase
{
    public int UserId { get; set; }
    public ICollection<Appointment> Appointments { get; set; }

    public User User { get; set; }
}