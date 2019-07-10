using ECommerceNoSQL.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerceNoSQL.Domain.Repositories
{
    public interface IProductRepository
    {
        Task Create(Product product);
        Task<IEnumerable<Product>> GetAll();
        Task Update(Product product);
        Task Delete(long id);
    }
}
