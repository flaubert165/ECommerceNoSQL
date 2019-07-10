using ECommerceNoSQL.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceNoSQL.Domain.Repositories
{
    public interface IUserRepository
    {
        Task Create(User user);
        Task<IEnumerable<User>> GetAll();
        Task Update(User user);
        Task Delete(long id);
        
    }
}
