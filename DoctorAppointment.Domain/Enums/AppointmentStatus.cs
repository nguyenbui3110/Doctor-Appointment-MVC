using System.ComponentModel.DataAnnotations;

namespace DoctorAppointment.Domain.Enums;

public enum AppointmentStatus
{
    [Display(Name = "ĐANG DUYỆT")]
    Pending = 0,
    [Display(Name = "ĐÃ XÁC NHẬN")]
    Confirmed = 1,
    [Display(Name = "ĐÃ HỦY")]
    Cancelled = 2,
    [Display(Name = "ĐÃ HOÀN THÀNH")]
    Completed = 3,
    [Display(Name = "BỊ TỪ CHỐI")]
    Rejected = 4
}
