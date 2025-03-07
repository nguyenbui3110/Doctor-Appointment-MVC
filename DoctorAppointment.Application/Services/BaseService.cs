using AutoMapper;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Domain.Data;

namespace DoctorAppointment.Application.Services;

public abstract class BaseService(IUnitOfWork unitOfWork, IMapper mapper, ICurrentUser currentUser)
{
    protected readonly IUnitOfWork UnitOfWork = unitOfWork;
    protected readonly IMapper Mapper = mapper;
    protected readonly ICurrentUser CurrentUser = currentUser;
}