using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IDoctorService _service;

    public HomeController(ILogger<HomeController> logger, IDoctorService service)
    {
        _logger = logger;
        _service = service;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public async Task<IActionResult> Doctors(Specialization specialization)
    {
        var doctors = await _service.GetBySpecialization(specialization);
        return View(doctors);
    }
}
