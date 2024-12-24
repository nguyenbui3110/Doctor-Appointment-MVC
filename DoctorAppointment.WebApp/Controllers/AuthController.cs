using DoctorAppointment.Application.Commons.Helpers;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.exceptions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.WebApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly AuthService _authService;
        private readonly IEmailSender _emailSender;
        private readonly IMailTemplateHelper _mailTemplateHelper;

        public AuthController(AuthService authService, IEmailSender emailSender, IMailTemplateHelper mailTemplateHelper)
        {
            _authService = authService;
            _emailSender = emailSender;
            _mailTemplateHelper = mailTemplateHelper;
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
        
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> ForgotPassword(ForgotPasswordModel model)
        {
            if (!ModelState.IsValid) return View(model);
            try
            {
                var token= await _authService.ForgetPasswordAsync(model.Email);
                var callbackUrl = Url.Action("ResetPassword", "Auth", new {token, email = model.Email}, Request.Scheme);
                var template = _mailTemplateHelper.ResetPasswordTemplate(callbackUrl);
                await _emailSender.SendEmailAsync(new Message(new List<string> {model.Email}, "Reset Password", template));
            }
            catch (EmailNotExistException)
            {
                ModelState.AddModelError("Email","Email không tồn tại");
                return View(model);
            }

            return RedirectToAction("ForgotPasswordConfirmation", "auth");
        }
        public ActionResult ForgotPasswordConfirmation()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ResetPassword(string token, string email)
        {
            return View(new ResetPasswordModel{Email = email, Token = token});
        }
        [HttpPost]
        public async Task<ActionResult> ResetPassword(ResetPasswordModel model)
        {
            if (!ModelState.IsValid) return View(model);
            if (!await _authService.ResetPasswordAsync(model))
            {
                ModelState.AddModelError("ResetPasswordError","Reset password không thành công");
                return View(model);
            }
            return RedirectToAction("login", "auth");
        }
    }
}
