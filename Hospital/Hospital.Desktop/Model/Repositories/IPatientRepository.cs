using System.Collections.Generic;
using Hospital.Desktop.Model.Entities;

namespace Hospital.Desktop.Model.Repositories
{
    public interface IPatientRepository
    {
        bool SavePatient(List<string> patientList);

        IEnumerable<Patient> GetAllPacients();
    }
}