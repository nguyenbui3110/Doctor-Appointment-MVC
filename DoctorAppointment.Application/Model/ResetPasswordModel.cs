using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Application.Model;

public class ResetPasswordModel
{
    public string Email { get; set; }
    public string Token { get; set; }
    [Required] public string NewPassword { get; set; }

    [Required]
    [Compare("NewPassword", ErrorMessage = "Mật khẩu không khớp")]
    public string ConfirmPassword { get; set; }
}