using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.WebApp.Controllers
{
    [Authorize]
    [Route("patient-appointment")]
    public class PatientAppointmentController : Controller
    {
        // GET: PatientAppointment
        public ActionResult Index()
        {
            return View();
        }

    }
}
