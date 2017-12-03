using Hospital.Desktop.Model.Repositories;
using Hospital.Desktop.View.Services;

namespace Hospital.Desktop.Presenter
{
    public class DoctorPresenter
    {
        private readonly IDoctorView _view;
        private readonly IDoctorRepository _models;

        public DoctorPresenter(IDoctorView view, IDoctorRepository models)
        {
            _view = view;
            view.GridDataSource = this;
            _models = models;

            GetAllDoctors();
        }

        public void GetAllDoctors()
        {
            _view.GridDataSource = _models.GetAllDoctors();
        }
    }
}