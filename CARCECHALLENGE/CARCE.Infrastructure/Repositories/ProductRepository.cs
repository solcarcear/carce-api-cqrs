using CARCE.Application.Dtos;
using CARCE.Application.Interfaces;

namespace CARCE.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyDbContext _dbContext;

        public ProductRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<ProductDto> AddAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetByIdAsync(int productId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> ListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> UpdateAsync(ProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
