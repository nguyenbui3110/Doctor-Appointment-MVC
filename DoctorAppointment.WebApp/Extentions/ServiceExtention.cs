using DoctorAppointment.Application.BackgroundServices;
using DoctorAppointment.Application.Commons;
using DoctorAppointment.Application.Commons.Helpers;
using DoctorAppointment.Application.Commons.Identity;
using DoctorAppointment.Application.Services;
using DoctorAppointment.Application.Services.Interfaces;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Infrastructure.Data;
using DoctorAppointment.Infrastructure.Email;
using DoctorAppointment.Infrastructure.Repositories;
using DoctorAppointment.WebApp.Commons.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Quartz;

namespace DoctorAppointment.WebApp.Extentions;

public static class ServiceExtentions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.Scan(scan => scan.FromAssemblyOf<BaseService>()
			.AddClasses(c => c.AssignableTo<BaseService>())
			.AsSelf()
			.WithScopedLifetime());
        services.Scan(scan => scan.FromAssemblyOf<IBaseService>()
            .AddClasses(c => c.AssignableTo<IBaseService>())
            .AsImplementedInterfaces()
            .WithScopedLifetime());
        return services;
    }

    public static IServiceCollection AddRepositorys(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));
        services.AddScoped<IDoctorRepo, DoctorRepo>();
        services.AddScoped<IPatientRepo, PatientRepo>();
        services.AddScoped<IAppointmentRepo, AppointmentRepo>();
        services.AddScoped<IScheduleRepo, ScheduleRepo>();

        return services;
    }

    public static IServiceCollection ConfigureIdentity(this IServiceCollection services)
    {
        services.AddIdentity<User, IdentityRole<int>>(options =>
        {
            options.Password.RequireDigit = false;
            options.Password.RequiredLength = 6;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.SignIn.RequireConfirmedAccount = false;
        }).AddEntityFrameworkStores<DrAppointmentDbContext>().AddDefaultTokenProviders();

        services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/login";
            options.AccessDeniedPath = "/";
            options.LogoutPath = "/logout";
            options.ReturnUrlParameter = string.Empty;
        });
        return services;
    }

    public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<DrAppointmentDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
        return services;
    }

    public static IServiceCollection AddCurrentUser(this IServiceCollection services)
    {
        services.AddScoped<ICurrentUser, CurrentUser>();
        services.AddHttpContextAccessor();
        return services;
    }
    public static IServiceCollection ConfigureConfigurations(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<EmailSettings>(configuration.GetSection("EmailConfiguration"));
        return services;
    }
    public static IServiceCollection AddEmailSender(this IServiceCollection services)
    {
        services.AddScoped<IEmailSender, EmailSender>();
        services.AddScoped<IMailTemplateHelper, MailTemplateHelper>();
        return services;
    }
     public static IServiceCollection AddQuartz(this IServiceCollection services)
    {
        services.AddQuartz(options =>
        {
            var jobKey = new JobKey("RemindAppointmentJob");
            options.AddJob<RemindAppointmentJob>(jobKey)
                   .AddTrigger(trigger =>
                        trigger.ForJob(jobKey)
                            .WithSimpleSchedule(schedule =>
                                schedule.WithIntervalInHours(24)
                                        .RepeatForever()));
            
            // // Run at 12:00 PM every day
            // var jobKey2 = new JobKey("MarkCheckoutDateBookingJob");
            // options.AddJob<MarkCheckOutJob>(jobKey2)
            //        .AddTrigger(trigger =>
            //             trigger.ForJob(jobKey2)
            //                 .WithCronSchedule("0 0 12 * * ? *"));
        });

        services.AddQuartzHostedService(options =>
        {
            options.AwaitApplicationStarted = true;
            options.WaitForJobsToComplete = true;
        });
            
        return services;
    }
}
