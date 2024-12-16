using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services;
using DoctorAppointment.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.WebApp.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserService _userService;
        public ProfileController(UserService userService)
        {
            _userService = userService;
        }
        // GET: ProfileController

        public  async Task<ActionResult> Index()
        {
            var CurrentUser = await _userService.GetCurrentUserAsync();
            return View(CurrentUser);
        }
        [HttpPost]
        public async Task<ActionResult> Update(UserViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            await _userService.UpdateUserAsync(model);
            return RedirectToAction("Index");
        }
    }
}
