
using DoctorAppointment.Application.Model;

namespace DoctorAppointment.Application.Services.Interfaces
{
    public interface IReviewService : IBaseService
    {
        Task<ReviewPostModel> GetReviewAsyns(int doctorId);
        Task<bool> AddReview(ReviewPostModel model);
        Task<bool> UpdateReview(ReviewPostModel model);
        Task<bool> CheckReviewAsyns(int doctorId);
    }
}
