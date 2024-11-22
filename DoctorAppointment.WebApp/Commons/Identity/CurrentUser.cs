using System;
using System.Security.Claims;
using DoctorAppointment.Application.Commons.Identity;

namespace DoctorAppointment.WebApp.Commons.Identity;

public class CurrentUser : ICurrentUser
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    public CurrentUser(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public string? Id => _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.NameIdentifier);
    public string? Name => _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Name);
    public string? Role => _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Role);
    public string? Email => _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Email);
    public string? AvatarUrl => _httpContextAccessor.HttpContext?.User.FindFirstValue(ClaimTypes.Uri);
}
