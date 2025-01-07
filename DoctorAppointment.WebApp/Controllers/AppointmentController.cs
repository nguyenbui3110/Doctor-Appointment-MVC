using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.WebApp.Hub;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace DoctorAppointment.WebApp.Controllers;

[Authorize]
public class AppointmentController : Controller
{
    private readonly IAppointmentService _appointmentService;
    private readonly IPatientService _patientService;
    private readonly IHubContext<AppointmentHub> _context;

    public AppointmentController(IAppointmentService appointmentService, IHubContext<AppointmentHub> context, IPatientService patientService)
    {
        _appointmentService = appointmentService;
        _patientService = patientService;
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
        if (!ModelState.IsValid) return Json(new { success = false, message = "invalid model" });
        var result = await _appointmentService.CreateAppointmentAsync(appointment);
        if (result != null)
        {
            await _context.Clients.All.SendAsync("UpdateTimeSlots", appointment.DoctorId?.ToString(),
                appointment.AppointmentDate?.ToString("yyyy-MM-dd"));
            await _context.Clients.All.SendAsync("UpdateAppointmentStatus", result.Doctor?.User.Id,
                result.Patient?.User.Id);
            return Json(new { success = true });
        }

        return Json(new { success = false, message = "error when create appointment" });
    }

    [Route("patient")]
    public IActionResult PatientAppointments()
    {
        return View();
    }

    [Route("appointments/patient")]
    public async Task<IActionResult> PatientAppointmentsFilter(AppointmentSearchModel model, int page = 1,
        int pageSize = 5)
    {
        var appointments = await _appointmentService.GetPatientAppointmentsAsync(model, page, pageSize);
        return PartialView("_AppointmentTable", appointments);
    }

    public async Task<IActionResult> PatientAppointmentCancel(int id)
    {
        var appointment = await _appointmentService.CancelAppointmentAsync(id);
        if (appointment != null)
        {
            await _context.Clients.All.SendAsync("UpdateTimeSlots", appointment.DoctorId?.ToString(),
                appointment.AppointmentDate?.ToString("yyyy-MM-dd"));
            await _context.Clients.All.SendAsync("UpdateAppointmentStatus", appointment.Doctor?.User.Id,
                appointment.Patient?.User.Id);
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
    public async Task<IActionResult> DoctorAppointmentsFilter(AppointmentSearchModel model, int page = 1,
        int pageSize = 5)
    {
        var appointments = await _appointmentService.GetDoctorAppointmentsAsync(model, page, pageSize);
        return PartialView("_DoctorAppointmentTable", appointments);
    }

    public async Task<IActionResult> DoctorAppointmentCancel(int id)
    {
        var appointment = await _appointmentService.CancelAppointmentAsync(id);
        if (appointment != null)
        {
            await _context.Clients.All.SendAsync("UpdateTimeSlots", appointment.DoctorId?.ToString(),
                appointment.AppointmentDate?.ToString("yyyy-MM-dd"));
            await _context.Clients.All.SendAsync("UpdateAppointmentStatus", appointment.Doctor?.User.Id,
                appointment.Patient?.User.Id);
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
            await _context.Clients.All.SendAsync("UpdateTimeSlots", appointment.DoctorId?.ToString(),
                appointment.AppointmentDate?.ToString("yyyy-MM-dd"));
            await _context.Clients.All.SendAsync("UpdateAppointmentStatus", appointment.Doctor?.User.Id,
                appointment.Patient?.User.Id);
            return RedirectToAction("DoctorAppointments");
        }

        ModelState.AddModelError("", "Error while cancel appointment");
        return RedirectToAction("DoctorAppointments");
    }
    public async Task<IActionResult> PatientAppointmentDetails(int id)
    {
        var appointment = await _appointmentService.GetAppointmentByIdAsync(id);
        var patient = await _patientService.GetPatientByIdAsync(appointment.PatientId);
        return PartialView("_PatientAppointmentDetail",(appointment,patient));
    }
    [HttpPost]
    public async Task<IActionResult> UpdateNotes(int id,string notes)
    {
        var appointment = await _appointmentService.UpdateAppointmentNotesAsync(id,notes);
        if(appointment)
        {
            return Json(new {success=true});
        }
        return Json(new {success=false});
    }
    public async Task<IActionResult> ScheduleCurrent()
    {
        var appointments = await _appointmentService.GetAllDoctorAppointmentsAsync();
        return View(appointments);
    }
    [HttpPost]
    public async Task<ActionResult> CheckAppointment(int doctorId)
    {
        if (await _appointmentService.CheckAppointmentAsync(doctorId))
        {
            return Json(new { success = true });
        }
        return Json(new { success = false });
    }
}