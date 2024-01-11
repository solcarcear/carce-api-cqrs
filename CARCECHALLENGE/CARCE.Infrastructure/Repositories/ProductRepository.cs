using CARCE.Application.Interfaces;
using CARCE.Domain.Product;

namespace CARCE.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task AddAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> ListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
