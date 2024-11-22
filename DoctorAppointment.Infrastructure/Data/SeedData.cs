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
        return new Faker<User>()
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
            .Generate(30);
    }
    private static List<Doctor> GetDoctors(List<User> users)
    {
        //first 10 users are doctors

        var doctors = users.Take(10).ToList();
        users.RemoveRange(0, 10);
        return new Faker<Doctor>()
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
                // Ensure the AppointmentDate is unique and within work hours (9 AM - 5 PM)
                do
                {
                    // Generate a random date within the past 30 days (adjust as needed)
                    var date = f.Date.Past(30);

                    // Generate a random time between 9 AM and 5 PM
                    var randomHour = f.Random.Number(9, 17); // 9 to 17 (5 PM)
                    var randomMinute = f.Random.Number(0, 59); // 0 to 59 minutes

                    // Combine date and time to form a complete DateTime
                    uniqueDate = date.AddHours(randomHour).AddMinutes(randomMinute);

                } while (!usedDates.Add(uniqueDate)); // Add returns false if the date already exists

                return uniqueDate;
            })
            .RuleFor(a => a.Status, f => f.PickRandom<AppointmentStatus>())
            .Generate(40);
        return appointments;
    }
}
