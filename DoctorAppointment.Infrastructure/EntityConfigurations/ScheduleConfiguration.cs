using DoctorAppointment.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DoctorAppointment.Infrastructure.EntityConfigurations;

public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
{
    public void Configure(EntityTypeBuilder<Schedule> builder)
    {
        builder.Property(w => w.DayOfWeek).IsRequired();
        builder.Property(w => w.StartTime).IsRequired().HasColumnType("time");
        builder.Property(w => w.EndTime).IsRequired().HasColumnType("time");
        builder.HasOne(w => w.Doctor)
            .WithMany(d => d.Schedules)
            .HasForeignKey(w => w.DoctorId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}