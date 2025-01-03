using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Infrastructure.Data;

namespace DoctorAppointment.Infrastructure.Repositories
{
    public class ReviewRepo : RepositoryBase<Review>, IReviewRepo
    {
        public ReviewRepo(DrAppointmentDbContext dbContext) : base(dbContext)
        {
        }
    }
}
