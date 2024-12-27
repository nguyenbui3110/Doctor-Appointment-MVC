using DoctorAppointment.WebApp.Extentions;
using DoctorAppointment.WebApp.Hub;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Add services to the container.


builder.Services.AddServices()
    .AddRepositorys()
    .AddDbContext(builder.Configuration)
    .ConfigureIdentity()
    .AddCurrentUser()
    .ConfigureConfigurations(builder.Configuration)
    .AddEmailSender()
    .AddQuartz()
    .AddSignalR();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddControllersWithViews();


var app = builder.Build();
await app.ApplyMigrationAsync(app.Logger);
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "schedule",
    pattern: "DoctorSchedule/{action=Index}/{doctorId?}",
    defaults: new { controller = "Schedule" });

app.MapHub<AppointmentHub>("/appointmentHub");

app.Run();
