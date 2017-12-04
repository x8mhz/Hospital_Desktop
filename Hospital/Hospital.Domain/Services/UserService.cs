using Hospital.Domain.Entities;
using Hospital.Domain.Interfaces.Repositories;
using Hospital.Domain.Interfaces.Services;

namespace Hospital.Domain.Services
{
    public class UserService : BaseService<User>, IUserServices
    {
        public UserService(IBaseRepository<User> repository) 
            : base(repository)
        {
        }
    }
}