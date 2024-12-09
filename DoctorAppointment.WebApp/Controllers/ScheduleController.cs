using DoctorAppointment.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.WebApp.Controllers
{
    public class ScheduleController : Controller
    {
        private readonly IScheduleService _scheduleService;
        private readonly IAppointmentService _appointmentService;
        public ScheduleController(IScheduleService scheduleService, IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
            _scheduleService = scheduleService;
        }
        // GET: ScheduleController
        public ActionResult Index()
        {
            var schedule = _scheduleService.GetDoctorScheduleAsync(1, System.DayOfWeek.Monday);
            return Ok(schedule);
        }
        public async Task<ActionResult> GetFreeTimeSlots(int doctorId, DateTime date)
        {

            var timeSlots = await _appointmentService.GetFreeTimeSlotsAsync(doctorId, date);
            return PartialView("_TimeSlot",timeSlots);
        }

    }
}
