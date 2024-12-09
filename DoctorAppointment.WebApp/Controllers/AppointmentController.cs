using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.WebApp.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }
        // GET: AppointmentController
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> BookAppointment(AppointmentPostModel appointment)
        {
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message="invalid model" });
            }
            if(await _appointmentService.CreateAppointmentAsync(appointment))
                return Json(new { success = true});
            return Json(new { success = false, message="error when create appointment" });
        }

    }

}
