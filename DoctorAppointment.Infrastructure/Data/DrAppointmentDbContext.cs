using System;
using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Entities.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DoctorAppointment.Application.Commons.Identity;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DoctorAppointment.Infrastructure.Data;

public class DrAppointmentDbContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    private readonly ICurrentUser _currentUser;
    public DrAppointmentDbContext(DbContextOptions<DrAppointmentDbContext> options, ICurrentUser currentUser) : base(options)
    {
        
        _currentUser = currentUser;
    }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Appointment> Appointments { get; set; }

    protected override void OnModelCreating (ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DrAppointmentDbContext).Assembly);
        modelBuilder.AddIdentitySeedData();
        base.OnModelCreating(modelBuilder);
        // Bỏ tiền tố AspNet của các bảng: mặc định các bảng trong IdentityDbContext có
        // tên với tiền tố AspNet như: AspNetUserRoles, AspNetUser ...
        // Đoạn mã sau chạy khi khởi tạo DbContext, tạo database sẽ loại bỏ tiền tố đó
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var tableName = entityType.GetTableName();
            if (tableName.StartsWith("AspNet")) entityType.SetTableName(tableName.Substring(6));
        }
        // Add soft delete query filter
        // https://www.thereformedprogrammer.net/ef-core-in-depth-soft-deleting-data-with-global-query-filters/
        var softDeleteEntityTypes = modelBuilder.Model
            .GetEntityTypes()
            .Where(e => e.ClrType.IsAssignableFrom(typeof(IDeleteEntity)));
        
        foreach (var entityType in softDeleteEntityTypes)
            entityType.AddSoftDeleteQueryFilter();
        
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Enable sensitive data logging for debugging purposes
        optionsBuilder.EnableSensitiveDataLogging();
        base.OnConfiguring(optionsBuilder);
    }
    
    
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        SetAuditableEntityProperties();
        SetSoftDeleteEntityProperties();
        return base.SaveChangesAsync(cancellationToken);
    }
    
    private void SetAuditableEntityProperties()
    {
        var userId = int.TryParse(_currentUser.Id, out var id) ? id : 0;
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.CreatedBy = userId;
                    entry.Entity.CreatedAt = DateTime.UtcNow;
                    break;

                case EntityState.Modified:
                    entry.Entity.LastModifiedBy = userId;
                    entry.Entity.LastModifiedAt = DateTime.UtcNow;
                    break;
            }
        }
    }
    
    private void SetSoftDeleteEntityProperties()
    {
        foreach (var entry in ChangeTracker.Entries<IDeleteEntity>())
        {
            if (entry.State != EntityState.Deleted) continue;
            entry.State = EntityState.Modified;
            entry.Entity.IsDeleted = true;
        }
    }
}

public static class SoftDeleteQueryExtension
{
    public static void AddSoftDeleteQueryFilter(
        this IMutableEntityType entityData)
    {
        var methodToCall = typeof(SoftDeleteQueryExtension)
            .GetMethod(nameof(GetSoftDeleteFilter))!
            .MakeGenericMethod(entityData.ClrType);
        
        var filter = methodToCall.Invoke(null, []);
        
        entityData.SetQueryFilter((LambdaExpression)filter!);
        entityData.AddIndex(entityData.FindProperty(nameof(IDeleteEntity.IsDeleted))!);
    }
 
    private static LambdaExpression GetSoftDeleteFilter<TEntity>() where TEntity : IDeleteEntity
    {
        Expression<Func<TEntity, bool>> filter = x => !x.IsDeleted;
        return filter;
    }
}