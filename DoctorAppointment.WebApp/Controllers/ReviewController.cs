using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.WebApp.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewService _reviewService;

        public ReviewController(IReviewService reviewService) 
        {
            _reviewService = reviewService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ReviewBox()
        {
            return PartialView("_ReviewBox");
        }
        public ActionResult ReviewBoxUpdate()
        {
            return PartialView("_ReviewBoxUpdate");
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> ReviewDoctor(ReviewPostModel model)
        {
            if (await _reviewService.AddReview(model))
            {
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        public async Task<ActionResult> UpdateReviewDoctor(ReviewPostModel model)
        {
            if (await _reviewService.UpdateReview(model))
            {
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        public async Task<ActionResult> CheckReview(int doctorId)
        {
            if (await _reviewService.CheckReviewAsyns(doctorId))
            {
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        public async Task<ActionResult> GetReview(int doctorId)
        {
            var review = await _reviewService.GetReviewAsyns(doctorId);
            return Json(new { review = review });
        }
    }
}
