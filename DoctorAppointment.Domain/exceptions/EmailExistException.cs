using System;

namespace DoctorAppointment.Domain.exceptions;

public class EmailExistException : Exception
{
    public EmailExistException(string message) : base(message)
    {
    }
}