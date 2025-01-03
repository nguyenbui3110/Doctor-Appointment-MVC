using DoctorAppointment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorAppointment.Infrastructure.EntityConfigurations
{
    public class ReviewConfigurations : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasOne(r => r.Doctor)
                .WithMany(d => d.Reviews)
                .HasForeignKey(r => r.DoctorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(r => r.Patient)
                .WithMany(d => d.Reviews)
                .HasForeignKey(r => r.PatientId)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Property(r => r.Rating).IsRequired().HasColumnType("int");
            builder.Property(a => a.ReviewTime).IsRequired().HasColumnType("time");
        }
    }
}
