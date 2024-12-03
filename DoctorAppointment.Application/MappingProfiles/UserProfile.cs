using System;
using AutoMapper;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Application.MappingProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserViewModel>().ReverseMap();
            
    }
}
