using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Application.Model;

public class RegisterModel
{
    [Required]
    [StringLength(50, MinimumLength = 5)]
    [RegularExpression(@"^\S*$", ErrorMessage = "Username cannot contain spaces.")]
    public string UserName { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 10)]
    public string FullName { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    [DataType(DataType.Password)]
    [StringLength(16, MinimumLength = 6)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Please confirm your password.")]
    [StringLength(16, MinimumLength = 6)]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Passwords do not match.")]
    public string ConfirmPassword { get; set; }

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
}