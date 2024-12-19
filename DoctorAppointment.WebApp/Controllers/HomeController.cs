using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DoctorAppointment.Application.Model;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.WebApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IDoctorService _doctorService;

    public HomeController(ILogger<HomeController> logger, IDoctorService doctorService)
    {
        _logger = logger;
        _doctorService = doctorService;
    }

    public async Task<IActionResult> Index()
    {
        var doctors = await _doctorService.GetAll();
        return View(doctors);
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
        var doctors = await _doctorService.GetBySpecialization(specialization);
        return View(doctors);
    }

    public async Task<IActionResult> SearchDoctors(string searchQuery, Specialization specialization)
    {
        var doctors = await _doctorService.GetByNameAndSpecialization(searchQuery, specialization);
        return View("Doctors", doctors);
    }

    public async Task<IActionResult> DoctorDetail(int id)
    {
        var doctor = await _doctorService.GetByIdAsync(id);
        return View(doctor);
    }
}
