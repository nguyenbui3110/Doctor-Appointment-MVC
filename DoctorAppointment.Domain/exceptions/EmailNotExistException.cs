using System;

namespace DoctorAppointment.Domain.exceptions;

public class EmailNotExistException : Exception
{
    public EmailNotExistException(string message) : base(message)
    {
    }
}
