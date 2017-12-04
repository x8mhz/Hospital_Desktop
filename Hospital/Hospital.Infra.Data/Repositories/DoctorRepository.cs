using Hospital.Domain.Entities;
using Hospital.Domain.Interfaces.Repositories;

namespace Hospital.Infra.Data.Repositories
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        
    }
}