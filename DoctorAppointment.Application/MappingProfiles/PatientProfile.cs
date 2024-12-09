using AutoMapper;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Application.MappingProfiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile()
        {
            CreateMap<Patient, PatientViewModel>()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.User, opt => opt.MapFrom(src => src.User)).ReverseMap();
            CreateMap<DoctorPostModel, Doctor>();
        }
    }
}
