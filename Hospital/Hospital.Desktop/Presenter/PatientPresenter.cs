using Hospital.Desktop.Model.Repositories;
using Hospital.Desktop.View.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Hospital.Desktop.Presenter
{
    public class PatientPresenter
    {
        private readonly IPatientView _service;
        private readonly IPatientRepository _repository;

        public PatientPresenter(IPatientView service)
        {
            _service = service;
        }

        public PatientPresenter(IPatientView service, IPatientRepository repository)
        {
            _service = service;
            service.GridDataSource = this;
            _repository = repository;

            GetAllPatients();
        }

        public bool SavePatient()
        {
            var model = new PatientRepository();
            var patientList = new List<string>();

            patientList.Insert(0, _service.NameComplete);
            patientList.Insert(1, _service.Genere);
            patientList.Insert(2, Convert.ToString(_service.BirthDate, CultureInfo.InvariantCulture));
            patientList.Insert(3, _service.Document);
            patientList.Insert(4, _service.Telephone);
            patientList.Insert(5, _service.ZipCode);
            patientList.Insert(6, _service.Street);
            patientList.Insert(7, _service.Number);
            patientList.Insert(8, _service.Country);
            patientList.Insert(9, _service.State);
            patientList.Insert(10, _service.City);
            patientList.Insert(11, _service.Notice);
            patientList.Insert(12, _service.Specialization);

            return model.SavePatient(patientList);
        }

        public void GetAllPatients()
        {
            _service.GridDataSource = _repository.GetAllPacients();
        }
    }
}