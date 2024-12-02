using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Domain.Enums;

public enum Specialization
{
    [Display(Name = "Đa khoa")]
    GeneralPractitioner = 1, //đa khoa
    [Display(Name = "Tim mạch")]
    Cardiologist = 2, // tim mạch
    [Display(Name = "Da liễu")]
    Dermatologist = 3, //da liễu
    [Display(Name = "Thần kinh")]
    Neurologist = 4, //thần kinh
    [Display(Name = "Nhi khoa")]
    Pediatrician = 5, //khi khoa
}
