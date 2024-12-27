using DoctorAppointment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorAppointment.Infrastructure.EntityConfigurations;

public class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.HasOne(p => p.User)
            .WithOne(u => u.Patient)
            .HasForeignKey<Patient>(p => p.UserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}