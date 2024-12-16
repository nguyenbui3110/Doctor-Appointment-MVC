using System;
using AutoMapper;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Application.MappingProfiles;

public class AppointmentProfile :Profile
{
    public AppointmentProfile()
    {
        CreateMap<Appointment,AppointmentPostModel>().ReverseMap();
        CreateMap<Appointment,AppointmentViewModel>().ForMember(x=>x.DoctorName,opt=>opt.MapFrom(src=>src.Doctor.User.FullName))
            .ForMember(x=>x.PatientName,opt=>opt.MapFrom(src=>src.Patient.User.FullName));
    }
}
