using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Domain.Data
{
    public interface IReviewRepo : IRepository<Review>
    {
        public IQueryable<Review> GetDoctorReview(int doctorId);
        public Task<bool> CheckReviewAsync(int doctorId, int patientId);

        public Task<Review> GetReviewAsync(int doctorId, int patientId);
    }
}
