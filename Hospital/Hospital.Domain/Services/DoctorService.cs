using Hospital.Domain.Entities;
using Hospital.Domain.Interfaces.Repositories;
using Hospital.Domain.Interfaces.Services;

namespace Hospital.Domain.Services
{
    public class DoctorService : BaseService<Doctor>, IDoctorService
    {
        public DoctorService(IBaseRepository<Doctor> repository) 
            : base(repository)
        {

        }
    }
}