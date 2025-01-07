using DoctorAppointment.Application.Model;
using DoctorAppointment.Domain.Entities;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IAppointmentService : IBaseService
{
    Task<PagingItem<AppointmentViewModel>> GetDoctorAppointmentsAsync(AppointmentSearchModel model, int page,
        int pageSize);

    Task<PagingItem<AppointmentViewModel>> GetPatientAppointmentsAsync(AppointmentSearchModel model, int page,
        int pageSize);

    //Get free time slot on a specific date
    Task<IEnumerable<TimeSpan>> GetFreeTimeSlotsAsync(int doctorId, DateTime date);
    public Task<Appointment> CreateAppointmentAsync(AppointmentPostModel model);
    public Task<Appointment> CancelAppointmentAsync(int id);
    public Task<Appointment> ConfirmAppointmentAsync(int id);
    public Task<AppointmentViewModel> GetAppointmentByIdAsync(int id);
    public Task<bool> UpdateAppointmentNotesAsync(int id, string notes);
    Task<List<AppointmentViewModel>> GetAllDoctorAppointmentsAsync();
    public Task<bool> CheckAppointmentAsync(int doctorId);
}
