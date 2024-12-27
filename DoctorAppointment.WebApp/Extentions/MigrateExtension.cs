using System;
using DoctorAppointment.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.WebApp.Extentions;

public static class MigrateExtension
{
    public static async Task ApplyMigrationAsync(this IApplicationBuilder app, ILogger logger)
    {
        using var scope = app.ApplicationServices.CreateScope();

        var context = scope.ServiceProvider.GetRequiredService<DrAppointmentDbContext>();
        await context.Database.MigrateAsync();
    }
}