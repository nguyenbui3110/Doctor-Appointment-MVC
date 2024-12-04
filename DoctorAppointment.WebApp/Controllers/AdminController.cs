using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly IDoctorService _doctorService;
        public AdminController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        // GET: AdminController
        public async Task<ActionResult> Index(int page = 1)
        {
            var model = await _doctorService.GetPagedAsync(page);
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
            if(!ModelState.IsValid)
                return PartialView("_AddDoctor", model);
            if(await _doctorService.AddDoctor(model))
            {
                return Json(new { success = true });    
            }
            ModelState.AddModelError("", "Error while adding doctor");
            return PartialView("_AddDoctor", model);
        }
        public async Task<ActionResult> UpdateDoctor(int id)
        {
            var model = await _doctorService.GetByIdAsync(id);
            return PartialView("_UpdateDoctor", model);
        }
        [HttpPost]
        public async Task<ActionResult> UpdateDoctor(DoctorViewModel model)
        {
            // if(!ModelState.IsValid)
            //     return PartialView("_UpdateDoctor", model);
            if(await _doctorService.UpdateDoctor(model))
            {
                return Json(new { success = true });    
            }
            ModelState.AddModelError("", "Error while updating doctor");
            return PartialView("_UpdateDoctor", model);
        }
    }
}
