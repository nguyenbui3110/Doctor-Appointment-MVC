using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Bogus;
using DoctorAppointment.Domain.Constants;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DoctorAppointment.Infrastructure.Data;

public static class SeedData
{
    public static void AddIdentitySeedData(this ModelBuilder modelBuilder)
    {
        var roles = GetDefaultRoles();
        modelBuilder.Entity<IdentityRole<int>>().HasData(roles);
        var admin = GetAdmin();
        modelBuilder.Entity<User>().HasData(admin);
        modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
        {
            RoleId = roles[0].Id,
            UserId = admin.Id
        });

        var user = GetUser();
        modelBuilder.Entity<User>().HasData(user);
        var doctors = GetDoctors(user);
        var patients = GetPatients(user);

        modelBuilder.Entity<Patient>().HasData(patients);
        modelBuilder.Entity<Doctor>().HasData(doctors);
        modelBuilder.Entity<Schedule>().HasData(GetSchedules(doctors));
        modelBuilder.Entity<Appointment>().HasData(GetAppointment(doctors, patients));

        modelBuilder.Entity<IdentityUserRole<int>>().HasData(doctors.Select(b => new IdentityUserRole<int>
        {
            RoleId = roles[1].Id,
            UserId = b.UserId
        }));

    }


    private static User GetAdmin()
    {
        return new User
        {
            Id = 1,
            FullName = "Admin",
            Email = "admin@gmail.com",
            NormalizedEmail = "ADMIN@GMAIL.COM",
            UserName = "admin",
            NormalizedUserName = "ADMIN",
            Address = "Admin Address",
            PhoneNumber = "123456789",
            EmailConfirmed = true,
            SecurityStamp = Guid.NewGuid().ToString(),
            PasswordHash = new PasswordHasher<User>().HashPassword(null!, "Admin@123")
        };
    }

    private static List<IdentityRole<int>> GetDefaultRoles()
    {
        var roles = new List<IdentityRole<int>>
        {
            new() { Id = 1, Name = AppRole.Admin, NormalizedName = AppRole.Admin.ToUpper() },
            new() { Id = 2, Name = AppRole.Doctor, NormalizedName = AppRole.Doctor.ToUpper() }
        };
        return roles;
    }
    private static List<User> GetUser()
    {
        return new Faker<User>("vi")
            .RuleFor(u => u.Id, f => f.IndexFaker + 2)
            .RuleFor(u => u.FullName, f => $"{f.Name.LastName()} {f.Name.FirstName()}")
            .RuleFor(u => u.Email, f => f.Internet.Email())
            .RuleFor(u => u.NormalizedEmail, (_,
                u) => u.Email?.ToUpper())
            .RuleFor(u => u.UserName, (_,
                u) => u.Email)
            .RuleFor(u => u.NormalizedUserName, (_,
                u) => u.UserName?.ToUpper())
            .RuleFor(u => u.Address, f => f.Address.StreetAddress())
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber())
            .RuleFor(u => u.EmailConfirmed, _ => true)
            .RuleFor(u => u.SecurityStamp, _ => Guid.NewGuid().ToString())
            .RuleFor(u => u.PasswordHash, _ => new PasswordHasher<User>().HashPassword(null!, "User@123"))
            .RuleFor(u => u.AvatarUrl, (f, u) => f.Image.PlaceholderUrl(250, 250, u.FullName))
            .RuleFor(u => u.DateOfBirth, f => f.Date.Past(30).Date)
            .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
            .Generate(100);
    }
    private static List<Doctor> GetDoctors(List<User> users)
    {
        //first 10 users are doctors

        var doctors = users.Take(20).ToList();
        return new Faker<Doctor>("vi")
            .RuleFor(d => d.Id, f => f.IndexFaker + 1)
            .RuleFor(d => d.UserId, f => doctors[f.IndexFaker].Id)
            .RuleFor(d => d.Specialization, f => f.PickRandom<Specialization>())
            .RuleFor(d => d.YearsOfExperience, f => f.Random.Number(1, 10))
            .RuleFor(d => d.About, (f, d) =>
            {
                var memberInfo = typeof(Specialization).GetMember(d.Specialization.ToString())[0];
                var displayAttribute = memberInfo.GetCustomAttribute<DisplayAttribute>();
                var displayName = displayAttribute?.Name ?? d.Specialization.ToString();
                return $"Bác sĩ có hơn {d.YearsOfExperience} năm trong lĩnh vực {displayName}";
            })
            .Generate(20);

    }
    private static List<Patient> GetPatients(List<User> users)
    {
        return new Faker<Patient>()
            .RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.UserId, f => f.IndexFaker + 1)
            .Generate(users.Count + 1);
    }
    private static List<Appointment> GetAppointment(List<Doctor> doctors, List<Patient> patients)
    {
        var usedDateTimePairs = new HashSet<(DateTime, TimeSpan)>();

        var appointments = new Faker<Appointment>()
            .RuleFor(a => a.Id, f => f.IndexFaker + 1)
            .RuleFor(a => a.DoctorId, f => f.PickRandom(doctors).Id)
            .RuleFor(a => a.PatientId, f => f.PickRandom(patients).Id)
            .RuleFor(a => a.AppointmentDate, (f, a) =>
            {
                DateTime appointmentDate;
                TimeSpan startTime;

                // Ensure unique (AppointmentDate, StartTime) pairs
                do
                {
                    appointmentDate = f.Date.Between(DateTime.Now.AddMonths(-30), DateTime.Now.AddDays(30)).Date;
                    startTime = TimeSpan.FromHours(f.Random.Int(8, 17));
                } while (!usedDateTimePairs.Add((appointmentDate, startTime)));

                a.StartTime = startTime; // Assign the unique start time here
                return appointmentDate;
            })
            .RuleFor(a => a.StartTime, (f, a) => a.StartTime) // Already assigned in AppointmentDate rule
            .RuleFor(a => a.EndTime, (f, a) => a.StartTime?.Add(TimeSpan.FromHours(1)))
            .RuleFor(a => a.Status, f => f.PickRandom<AppointmentStatus>())
            .Generate(200);

        return appointments;
    }
    private static List<Schedule> GetSchedules(List<Doctor> doctors)
    {
        // for each doctor generate schedule each day of the week

        var schedules = new List<Schedule>();
        var id = 1;
        foreach (var doctor in doctors)
        {

            for (var i = 1; i < 7; i++)
            {
                schedules.Add(new Schedule
                {
                    Id = id++,
                    DoctorId = doctor.Id,
                    DayOfWeek = (DayOfWeek)i,
                    StartTime = TimeSpan.FromHours(8),
                    EndTime = TimeSpan.FromHours(17)
                });
            }
        }

        return schedules;
    }
}
