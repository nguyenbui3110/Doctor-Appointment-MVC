using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services;
using DoctorAppointment.Domain.exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.WebApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }

        // GET: AuthController
        [Route("login")]
        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated) return RedirectToAction("Index", "Home");
            return View();
        }

        [Route("login")]
        [HttpPost]
        public async Task<ActionResult> Login(LoginModel model)
        {
            if(!await _authService.LoginAsync(model))
            {
                ModelState.AddModelError("LoginError","Sai tài khoản hoặc mật khẩu");
                return View(model);
            }
            return RedirectToAction("Index", "Home");
        }

        [Route("register")]
        public ActionResult Register()
        {
            if (User.Identity.IsAuthenticated) return RedirectToAction("Index", "Home");
            return View();
        }

        [Route("register")]
        [HttpPost]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid) return View(model);
            try
            {
                await _authService.RegisterAsync(model);
            }
            catch (UserNameExistException)
            {
                ModelState.AddModelError("UserName","Tài khoản đã tồn tại");
                return View(model);
            }
            catch (EmailExistException)
            {
                ModelState.AddModelError("Email","Email đã tồn tại");
                return View(model);
            }


            return RedirectToAction("Index", "Home");
        }

        [Authorize]
        [Route("logout")]
        public async Task<ActionResult> Logout()
        {
            await _authService.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }


    }
}
