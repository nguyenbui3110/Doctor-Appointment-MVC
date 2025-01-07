using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Infrastructure.Repositories
{
    public class ReviewRepo : RepositoryBase<Review>, IReviewRepo
    {
        public ReviewRepo(DrAppointmentDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> CheckReviewAsync(int doctorId, int patientId)
        {
            var hasAppointment = await DbSet.AnyAsync(a => a.DoctorId == doctorId && a.PatientId == patientId);
            return hasAppointment;
        }

        public IQueryable<Review> GetDoctorReview(int doctorId)
        {
            return DbSet.Where(a => a.DoctorId == doctorId);
        }

        public Task<Review> GetReviewAsync(int doctorId, int patientId)
        {
            return DbSet.Where(r => r.DoctorId == doctorId && r.PatientId == patientId).FirstOrDefaultAsync();
        }
    }
}
