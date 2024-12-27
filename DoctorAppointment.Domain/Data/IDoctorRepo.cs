using DoctorAppointment.Domain.Entities;
using DoctorAppointment.Domain.Enums;

namespace DoctorAppointment.Domain.Data
{
    public interface IDoctorRepo: IRepository<Doctor>
    {
        Task<Doctor?> GetDoctorByUserIdAsync(int id);
        IQueryable<Doctor> GetByNameAndSpecialization(string name, Specialization specialization);
        IQueryable<Doctor> GetBySpecialization(Specialization specialization);
        public  Task<string?> GetDoctorNameAsync(int doctorId);
        public Task<Doctor> UpdateDoctorAllScheduleAsync(Doctor doctor,List<Schedule> schedule);
    }
}
