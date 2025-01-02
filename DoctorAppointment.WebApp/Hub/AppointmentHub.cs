using Microsoft.AspNetCore.SignalR;

namespace DoctorAppointment.WebApp.Hub;

public class AppointmentHub : Microsoft.AspNetCore.SignalR.Hub
{
    public async Task NotifyTimeSlotsUpdated(int doctorId, string date)
    {
        await Clients.All.SendAsync("UpdateTimeSlots", doctorId, date);
    }

    public async Task NotifyAppointmentStatusUpdated(int doctorId, int patientId)
    {
        await Clients.All.SendAsync("UpdateAppointmentStatus", doctorId, patientId);
    }

}