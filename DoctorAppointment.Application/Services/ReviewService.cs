using AutoMapper;
using DoctorAppointment.Application.Commons.Helpers;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Application.Services
{
    internal class ReviewService(
    IPatientRepo patientRepo,
    IDoctorRepo doctorRepo,
    IScheduleService scheduleService,
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ICurrentUser currentUser)
    : BaseService(unitOfWork, mapper, currentUser), IReviewService
    {
    }
}
