using DoctorAppointment.Application.Model;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IAppointmentService : IBaseService
{
    Task<Appointment> GetDoctorAppointmentsAsync(int doctorId, DateTime date);
    Task<PagingItem<AppointmentViewModel>> GetPatientAppointmentsAsync(AppointmentSearchModel model, int page, int pageSize);
    //Get free time slot on a specific date
    Task<IEnumerable<TimeSpan>> GetFreeTimeSlotsAsync(int doctorId, DateTime date);
    public Task<bool> CreateAppointmentAsync(AppointmentPostModel model);
    public Task<Appointment> CancelAppointmentAsync(int id);
}
