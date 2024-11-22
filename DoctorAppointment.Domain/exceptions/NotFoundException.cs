using System;

namespace DoctorAppointment.Domain.exceptions;

public class NotFoundException: Exception
{
    public NotFoundException(string name, object key)
        : base($"Entity \"{name}\" ({key}) was not found.")
    {
    }
}
