using System;

namespace DoctorAppointment.Domain.exceptions;

public class UserNameExistException : Exception
{
    public UserNameExistException(string message) : base(message)
    {
    }
}
