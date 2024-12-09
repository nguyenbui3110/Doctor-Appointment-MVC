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
    }
}
