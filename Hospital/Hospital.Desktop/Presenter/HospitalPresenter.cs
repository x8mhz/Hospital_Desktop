using Hospital.Desktop.Model.Repositories;
using Hospital.Desktop.View.Services;

namespace Hospital.Desktop.Presenter
{
    public class HospitalPresenter
    {
        private readonly IHospitalService _service;
        private readonly IHospitalRepository _repository;

        public HospitalPresenter(IHospitalService service, IHospitalRepository repository)
        {
            _service = service;
            service.GridDataSource = this;
            _repository = repository;

            GetAllHospitals();
        }

        public void GetAllHospitals()
        {
            _service.GridDataSource = _repository.GetAllHospitals();
        }
    }
}