using System;
using DoctorAppointment.Domain.Data;
using Quartz;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Application.BackgroundServices;

public class CheckCompleteAppointmentJob : IJob
{
    private readonly IAppointmentRepo _appointmentRepo;
    private readonly IUnitOfWork _unitOfWork;

    public CheckCompleteAppointmentJob(IAppointmentRepo appointmentRepo, IUnitOfWork unitOfWork)
    {
        _appointmentRepo = appointmentRepo;
        _unitOfWork = unitOfWork;
    }

    public async Task Execute(IJobExecutionContext context)
    {
        var appointments = await _appointmentRepo.GetAppointmentByStatusAsync(AppointmentStatus.Confirmed);
        foreach (var appointment in appointments)
            if (appointment.AppointmentDate.Value.Add(appointment.EndTime.Value) < DateTime.Now)
                appointment.Status = AppointmentStatus.Completed;
        await _unitOfWork.SaveChangesAsync();
    }
}