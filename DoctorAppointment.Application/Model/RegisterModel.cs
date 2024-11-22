using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Application.Model;

public class RegisterModel
{
    [Required]
    [Length(5, 50)]
    public string UserName { get; set; }
    [Required]
    [Length(10, 50)]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Please confirm your password.")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    public string ConfirmPassword { get; set; }

    [DataType(DataType.EmailAddress)] public string Email { get; set; }
}