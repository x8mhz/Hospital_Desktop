using System.Collections.Generic;

namespace Hospital.Desktop.Model.Repositories
{
    public interface IPatientRepository
    {
        bool SavePatient(List<string> patientList);
    }
}