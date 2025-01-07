using AutoMapper;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Application.MappingProfiles
{
    public class ReviewProfile : Profile
    {
        public ReviewProfile() 
        {
            CreateMap<Review, ReviewPostModel>().ReverseMap();
            CreateMap<Review, ReviewPostModel>()
                .ForMember(x => x.Content, opt => opt.MapFrom(src => src.Content))
                .ForMember(x => x.Rating, opt => opt.MapFrom(src => src.Rating))
                .ForMember(x => x.DoctorId, opt => opt.MapFrom(src => src.DoctorId));
        }
    }
}
