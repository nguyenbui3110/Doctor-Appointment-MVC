using System;
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

        var User = GetUser();
        modelBuilder.Entity<User>().HasData(User);
        var Doctors = GetDoctors(User);
        var Patients = GetPatients(User);

        modelBuilder.Entity<Patient>().HasData(Patients);
        modelBuilder.Entity<Doctor>().HasData(Doctors);
        modelBuilder.Entity<Schedule>().HasData(GetSchedules(Doctors));
        modelBuilder.Entity<Appointment>().HasData(GetAppointment(Doctors, Patients));

        modelBuilder.Entity<IdentityUserRole<int>>().HasData(Doctors.Select(b => new IdentityUserRole<int>
        {
            RoleId = roles[2].Id,
            UserId = b.UserId
        }));
        modelBuilder.Entity<IdentityUserRole<int>>().HasData(Patients.Select(b => new IdentityUserRole<int>
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
            new() { Id = 2, Name = AppRole.Patient, NormalizedName = AppRole.Patient.ToUpper() },
            new() { Id = 3, Name = AppRole.Doctor, NormalizedName = AppRole.Doctor.ToUpper() }
        };
        return roles;
    }
    private static List<User> GetUser()
    {
        return new Faker<User>("vi")
            .RuleFor(u => u.Id, f => f.IndexFaker + 2)
            .RuleFor(u => u.FullName, f => f.Name.FullName())
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
            .RuleFor(u => u.AvatarUrl, (f,u) => f.Image.PlaceholderUrl(100, 100, u.FullName))
            .RuleFor(u => u.DateOfBirth, f => f.Date.Past(30).Date)
            .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
            .Generate(30);
    }
    private static List<Doctor> GetDoctors(List<User> users)
    {
        //first 10 users are doctors

        var doctors = users.Take(10).ToList();
        users.RemoveRange(0, 10);
        return new Faker<Doctor>("vi")
            .RuleFor(d => d.Id, f => f.IndexFaker + 1)
            .RuleFor(d => d.UserId, f => doctors[f.IndexFaker].Id)
            .RuleFor(d => d.Specialization, f => f.PickRandom<Specialization>())
            .RuleFor(d => d.About, f => f.Lorem.Sentence())
            .RuleFor(d => d.YearsOfExperience, f => f.Random.Number(1, 20))
            .Generate(10);

    }
    private static List<Patient> GetPatients(List<User> users)
    {
        return new Faker<Patient>()
            .RuleFor(p => p.Id, f => f.IndexFaker + 1)
            .RuleFor(p => p.UserId, f => users[f.IndexFaker].Id)
            .Generate(20);
    }
    private static List<Appointment> GetAppointment(List<Doctor> doctors, List<Patient> patients)
    {
        var usedDates = new HashSet<DateTime>();

        var appointments = new Faker<Appointment>()
            .RuleFor(a => a.Id, f => f.IndexFaker + 1)
            .RuleFor(a => a.DoctorId, f => f.PickRandom(doctors).Id)
            .RuleFor(a => a.PatientId, f => f.PickRandom(patients).Id)
            .RuleFor(a => a.AppointmentDate, (f, a) =>
            {
                DateTime uniqueDate;
                do
                {
                    // Generate a random date within the past 30 days (adjust as needed)
                    var date = f.Date.Between(DateTime.Now.AddDays(-30), DateTime.Now.AddDays(30)).Date;

                    uniqueDate = date;
                } while (!usedDates.Add(uniqueDate)); // Add returns false if the date already exists

                return uniqueDate;
            })
            .RuleFor(a => a.StartTime, f => TimeSpan.FromHours(f.Random.Int(8, 17)))
            .RuleFor(a => a.EndTime, (f, a) => a.StartTime?.Add(TimeSpan.FromHours(1)))
            .RuleFor(a => a.Status, f => f.PickRandom<AppointmentStatus>())
            .Generate(40);
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
