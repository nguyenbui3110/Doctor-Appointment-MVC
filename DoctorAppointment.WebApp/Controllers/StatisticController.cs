using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DoctorAppointment.WebApp.Controllers
{
    [Authorize(Roles = "Admin")]
    public class StatisticController : Controller
    {
        private readonly IStatisticsService _statisticsService;
        public StatisticController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }
        // GET: StatisticController
        public ActionResult GetDailyChart(DateRangeFilter filter)
        {
            
            var daily =  _statisticsService.GetDailyAppointmentsCount(filter);
            return PartialView("_DailyChart",daily);
        }
        public async Task<ActionResult> GetMonthlyChart(DateRangeFilter filter)
        {
            var monthly = await _statisticsService.GetMonthlyAppointmentsCountAsync(filter);
            return PartialView("_MonthlyChart",monthly);
        }
        public async Task<ActionResult> GetTopDoctorsChart(DateRangeFilter filter)
        {
            var topDoctors = await _statisticsService.GetTopDoctorsAsync(filter);
            return PartialView("_TopDoctorsChart",topDoctors);
        }
        public async Task<ActionResult> GetPatientChart(DateRangeFilter filter)
        {
            var patient = await _statisticsService.GetPatientCountAsync(filter);
            return PartialView("_PatientChart",patient);
        }

    }
}
