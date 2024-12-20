using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Enums;
using DoctorAppointment.Domain.exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IDoctorService _doctorService;
        private readonly IPatientService _patientService;

        public AdminController(IDoctorService doctorService, IPatientService patientService)
        {
            _doctorService = doctorService;
            _patientService = patientService;
        }

        // GET: AdminController
        public async Task<ActionResult> Index(int page = 1, string searchQuery = "", Specialization specialization = 0)
        {
            var model = await _doctorService.GetPagedAsync(page, searchQuery, specialization);
            ViewBag.SearchQuery = searchQuery;
            return View(model);
        }
        public ActionResult AddDoctor()
        {
            return PartialView("_AddDoctor", new DoctorPostModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddDoctor(DoctorPostModel model)
        {
            if (!ModelState.IsValid)
                return PartialView("_AddDoctor", model);
            try
            {
                if (await _doctorService.AddDoctor(model))
                {
                    return Json(new { success = true });
                }

            }
            catch (UserNameExistException)
            {
                ModelState.AddModelError("RegisterModel.UserName", "Username already exists");
                return PartialView("_AddDoctor", model);
            }
            catch (EmailExistException)
            {
                ModelState.AddModelError("RegisterModel.Email", "Email already exists");
                return PartialView("_AddDoctor", model);
            }
            ModelState.AddModelError("", "Error while adding doctor");
            return PartialView("_AddDoctor", model);
        }
        public async Task<ActionResult> UpdateDoctor(int id)
        {
            var model = await _doctorService.GetByAdminWithIdAsync(id);
            return PartialView("_UpdateDoctor", model);
        }
        [HttpPost]
        public async Task<ActionResult> UpdateDoctor(DoctorViewModel model)
        {
            // if(!ModelState.IsValid)
            //     return PartialView("_UpdateDoctor", model);
            if (await _doctorService.UpdateDoctor(model))
            {
                return Json(new { success = true });
            }
            ModelState.AddModelError("", "Error while updating doctor");
            return PartialView("_UpdateDoctor", model);
        }
        public async Task<ActionResult> DeleteDoctor(int id)
        {
            await _doctorService.DeleteDoctor(id);
            return RedirectToAction("Index");
        }
        public async Task<ActionResult> RestoreDoctor(int id)
        {
            await _doctorService.RestoreDoctor(id);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> PatientPage(int page = 1, string searchQuery = "")
        {
            var model = await _patientService.GetPagedAsync(page, searchQuery);
            ViewBag.SearchQuery = searchQuery;
            return View(model);
        }

        public async Task<ActionResult> DeletePatient(int id)
        {
            var model = await _patientService.DeletePatient(id);
            return RedirectToAction("PatientPage");
        }
        public async Task<ActionResult> RestorePatient(int id)
        {
            await _patientService.RestorePatient(id);
            return RedirectToAction("PatientPage");
        }
        public async Task<ActionResult> Statistics()
        {
            return View();
        }
    }
}
