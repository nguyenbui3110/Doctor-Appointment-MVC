using AutoMapper;
using DoctorAppointment.Application.Commons.Helpers;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Application.Services
{
    public class ReviewService(
    IReviewRepo reviewRepo,
    IPatientRepo patientRepo,
    IDoctorRepo doctorRepo,
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser)
    : BaseService(unitOfWork, mapper, currentUser), IReviewService
    {
        public async Task<bool> AddReview(ReviewPostModel model)
        {
            var review = Mapper.Map<Review>(model);
            var doctor = await doctorRepo.GetByIdAsync(model.DoctorId);
            var patient = await patientRepo.GetPatientByUserIdAsync(int.Parse(CurrentUser.Id));
            review.PatientId = patient.Id;
            review.ReviewDate = DateTime.Now.Date;
            review.ReviewTime = DateTime.Now.TimeOfDay;
            reviewRepo.Add(review);

            await UnitOfWork.SaveChangesAsync();

            doctor.Reviews = await reviewRepo.GetDoctorReview(doctor.Id).ToListAsync();
            doctor.AverageRating = doctor.Reviews.Average(r => r.Rating);
            await UnitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<bool> CheckReviewAsyns(int doctorId)
        {
            var patient = await patientRepo.GetPatientByUserIdAsync(int.Parse(CurrentUser.Id));
            return await reviewRepo.CheckReviewAsync(doctorId, patient.Id);
        }

        public async Task<ReviewPostModel> GetReviewAsyns(int doctorId)
        {
            var patient = await patientRepo.GetPatientByUserIdAsync(int.Parse(CurrentUser.Id));
            var review = await reviewRepo.GetReviewAsync(doctorId, patient.Id);
            return Mapper.Map<ReviewPostModel>(review);
        }

        public async Task<bool> UpdateReview(ReviewPostModel model)
        {
            var doctor = await doctorRepo.GetByIdAsync(model.DoctorId);
            var patient = await patientRepo.GetPatientByUserIdAsync(int.Parse(CurrentUser.Id));
            var review = await reviewRepo.GetReviewAsync(doctor.Id, patient.Id);

            review.Content = model.Content;
            review.Rating = model.Rating;
            review.ReviewDate = DateTime.Now.Date;
            review.ReviewTime = DateTime.Now.TimeOfDay;

            reviewRepo.Update(review);
            await UnitOfWork.SaveChangesAsync();

            doctor.Reviews = await reviewRepo.GetDoctorReview(doctor.Id).ToListAsync();
            doctor.AverageRating = doctor.Reviews.Average(r => r.Rating);
            await UnitOfWork.SaveChangesAsync();
            return true;
        }
    }
}