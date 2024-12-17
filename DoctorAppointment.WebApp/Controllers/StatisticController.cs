using DoctorAppointment.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.WebApp.Controllers
{
    public class StatisticController : Controller
    {
        private readonly IStatisticsService _statisticsService;
        public StatisticController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }
        // GET: StatisticController
        public ActionResult GetDailyChart()
        {
            return PartialView("_DailyChart");
        }
        public ActionResult GetMonthlyChart()
        {
            return PartialView("_MonthlyChart");
        }
        public ActionResult GetTopDoctorsChart()
        {
            return PartialView("_TopDoctorsChart");
        }
        public ActionResult GetPatientChart()
        {
            return PartialView("_PatientChart");
        }

    }
}
