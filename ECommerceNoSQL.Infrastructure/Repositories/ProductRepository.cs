using System.Collections.Generic;
using System.Threading.Tasks;
using ECommerceNoSQL.Domain.Entities;
using ECommerceNoSQL.Domain.Repositories;
using ECommerceNoSQL.Infrastructure.DataContext;
using MongoDB.Driver;
using MongoDbGenericRepository;

namespace ECommerceNoSQL.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private IMongoDbContext _context;
        private IMongoCollection<Product> _products;

        public ProductRepository(IMongoDbContext context, IECommerceDbSettings settings)
        {
            _context = context;
            _products = _context.GetCollection<Product>(settings.ProductsCollectionName);
        }

        public async Task Create(Product product)
        {
            await _products.InsertOneAsync(product);
        }

        public async Task Delete(long id)
        {
            await _products.DeleteOneAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            var list = await _products.FindAsync(Builders<Product> .Filter.Empty);

            return list.ToList();
        }

        public async Task Update(Product product)
        {
            await _products.ReplaceOneAsync(p => p.Id == product.Id, product);
        }
    }
}
