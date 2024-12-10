using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace DoctorAppointment.WebApp.Hubs;


public class AppointmentHub : Hub
{
    public async Task NotifyTimeSlotsUpdated(int doctorId, string date)
    {
        await Clients.All.SendAsync("UpdateTimeSlots", doctorId, date);
    }
}

