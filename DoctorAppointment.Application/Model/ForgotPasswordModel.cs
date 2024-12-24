using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Application.Model;

public class ForgotPasswordModel
{
    [Required]
    [EmailAddress]
    [Display(Name = "Nhập chính xác địa chỉ email")]
    public string Email { get; set; }
}
