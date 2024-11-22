using System;

namespace DoctorAppointment.Domain.Entities.Base;

public class AuditableEntity
{
    public DateTime CreatedAt { get; set; }
    public DateTime? LastModifiedAt { get; set; }
    public int? CreatedBy { get; set; }
    public int? LastModifiedBy { get; set; }
}
