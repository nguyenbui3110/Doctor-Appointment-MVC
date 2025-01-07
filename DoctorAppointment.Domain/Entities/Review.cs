using DoctorAppointment.Domain.Entities.Base;

namespace DoctorAppointment.Domain.Entities
{
    public class Review : EntityBase
    {
        public int? DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public int? PatientId { get; set; }
        public Patient? Patient { get; set; }
        public DateTime? ReviewDate { get; set; }
        public TimeSpan ReviewTime { get; set; }
        public string? Content { get; set; }
        public int Rating { get; set; }
    }
}
