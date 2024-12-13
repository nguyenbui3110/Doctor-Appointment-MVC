using System;
using System.ComponentModel.DataAnnotations;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.Model;

public class UserViewModel
{
    public int Id { get; set; }
    [Required]
    [Display(Name = "Họ và tên")]
    public string FullName { get; set; } = string.Empty;
    [Display(Name = "Địa chỉ")]
    [Required(AllowEmptyStrings = true)]
    public string? Address { get; set; }
    [DataType(DataType.Date)]
    // [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    [Display(Name = "Ngày sinh")]
    [Required]
    public DateTime? DateOfBirth { get; set; }
    [Display(Name = "Giới tính")]
    public Gender? Gender { get; set; }
    [Phone]
    [Display(Name = "Số điện thoại")]
    public string? PhoneNumber { get; set; }
    [EmailAddress]
    [Display(Name = "Email")]
    public string Email { get; set; } = string.Empty;
    public string? AvatarUrl { get; set; }
}
