using DoctorAppointment.Application.Model;

namespace DoctorAppointment.Application.Services.Interfaces;

public interface IPatientService : IBaseService

{
    Task<PagingItem<PatientViewModel>> GetPagedAsync(int page, string searchQuery, int pageSize = 8);
    Task<bool> DeletePatient(int id);
    Task<bool> RestorePatient(int id);
    Task<PatientViewModel> GetPatientByIdAsync(int id);
}