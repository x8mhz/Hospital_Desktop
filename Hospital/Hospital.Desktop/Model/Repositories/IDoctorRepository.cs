using System.Collections.Generic;
using Hospital.Desktop.Model.Entities;

namespace Hospital.Desktop.Model.Repositories
{
    public interface IDoctorRepository
    {
        IEnumerable<Doctor> GetAllDoctors();
    }
}