using Hospital.Desktop.Model.Repositories;
using Hospital.Desktop.View.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Hospital.Desktop.Presenter
{
    public class PatientPresenter
    {
        private readonly IPatientView _view;

        public PatientPresenter(IPatientView view)
        {
            _view = view;
        }

        public bool SavePatient()
        {
            var model = new PatientRepository();
            var patientList = new List<string>();

            patientList.Insert(0, _view.NameComplete);
            patientList.Insert(1, _view.Genere);
            patientList.Insert(2, Convert.ToString(_view.BirthDate, CultureInfo.InvariantCulture));
            patientList.Insert(3, _view.Document);
            patientList.Insert(4, _view.Telephone);
            patientList.Insert(5, _view.ZipCode);
            patientList.Insert(6, _view.Street);
            patientList.Insert(7, _view.Number);
            patientList.Insert(8, _view.Country);
            patientList.Insert(9, _view.State);
            patientList.Insert(10, _view.City);
            patientList.Insert(11, _view.Notice);
            patientList.Insert(12, _view.Specialization);

            return model.SavePatient(patientList);

        }
    }
}