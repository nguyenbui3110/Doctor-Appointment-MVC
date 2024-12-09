using DoctorAppointment.Application.Model;
using DoctorAppointment.Domain.Data;
using DoctorAppointment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoctorAppointment.Application.Services.Interfaces
{
    public interface IPatientService : IBaseService

    {
        Task<PagingItem<PatientViewModel>> GetPagedAsync(int page, int pageSize = 8);
        Task<bool> DeletePatient(int id);
    }
}
