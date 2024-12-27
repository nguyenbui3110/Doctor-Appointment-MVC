using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.WebApp.Hub;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace DoctorAppointment.WebApp.Controllers
{
    [Authorize]
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IHubContext<AppointmentHub> _context;
        public AppointmentController(IAppointmentService appointmentService, IHubContext<AppointmentHub> context)
        {
            _appointmentService = appointmentService;
            _context = context;
        }
        // GET: AppointmentController
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BookAppointment(AppointmentPostModel appointment)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message="invalid model" });
            }
            if(await _appointmentService.CreateAppointmentAsync(appointment))
            {
                await _context.Clients.All.SendAsync("UpdateTimeSlots", appointment.DoctorId?.ToString(), appointment.AppointmentDate?.ToString("yyyy-MM-dd"));
                return Json(new { success = true});

            }
                
            return Json(new { success = false, message="error when create appointment" });
        }
        [Route("patient")]
        public IActionResult PatientAppointments()
        {
            return View();
        }
        [Route("appointments/patient")]
        public async Task<IActionResult> PatientAppointmentsFilter(AppointmentSearchModel model, int page = 1, int pageSize = 5)
        {
            var appointments = await _appointmentService.GetPatientAppointmentsAsync(model,page,pageSize);
            return PartialView("_AppointmentTable", appointments);
        }
        public async Task<IActionResult> PatientAppointmentCancel(int id)
        {
            var appointment = await _appointmentService.CancelAppointmentAsync(id);
            if(appointment!=null)
            {
                await _context.Clients.All.SendAsync("UpdateTimeSlots", appointment.DoctorId?.ToString(), appointment.AppointmentDate?.ToString("yyyy-MM-dd"));
                return RedirectToAction("PatientAppointments");
            }
            ModelState.AddModelError("", "Error while cancel appointment");
            return RedirectToAction("PatientAppointments");
        }

        public IActionResult DoctorAppointments()
        {
            return View();
        }

        [Route("appointments/doctor")]
        public async Task<IActionResult> DoctorAppointmentsFilter(AppointmentSearchModel model, int page = 1, int pageSize = 5)
        {
            var appointments = await _appointmentService.GetDoctorAppointmentsAsync(model, page, pageSize);
            return PartialView("_DoctorAppointmentTable", appointments);
        }
        public async Task<IActionResult> DoctorAppointmentCancel(int id)
        {
            var appointment = await _appointmentService.CancelAppointmentAsync(id);
            if (appointment != null)
            {
                await _context.Clients.All.SendAsync("UpdateTimeSlots", appointment.DoctorId?.ToString(), appointment.AppointmentDate?.ToString("yyyy-MM-dd"));
                return RedirectToAction("DoctorAppointments");
            }
            ModelState.AddModelError("", "Error while cancel appointment");
            return RedirectToAction("DoctorAppointments");
        }

        public async Task<IActionResult> DoctorAppointmentConfirm(int id)
        {
            var appointment = await _appointmentService.ConfirmAppointmentAsync(id);
            if (appointment != null)
            {
                await _context.Clients.All.SendAsync("UpdateTimeSlots", appointment.DoctorId?.ToString(), appointment.AppointmentDate?.ToString("yyyy-MM-dd"));
                return RedirectToAction("DoctorAppointments");
            }
            ModelState.AddModelError("", "Error while cancel appointment");
            return RedirectToAction("DoctorAppointments");
        }
    }

}
