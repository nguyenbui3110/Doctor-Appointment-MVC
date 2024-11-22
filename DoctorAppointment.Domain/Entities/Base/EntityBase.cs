using System;

namespace DoctorAppointment.Domain.Entities.Base;

public class EntityBase : AuditableEntity, IDeleteEntity
{
    public int Id { get; set; }
    
    public bool IsDeleted { get; set; }
}
