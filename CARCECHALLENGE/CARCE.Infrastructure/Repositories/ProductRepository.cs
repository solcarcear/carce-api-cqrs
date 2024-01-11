using CARCE.Application.Dtos;
using CARCE.Application.Interfaces;
using CARCE.Domain.Product;

namespace CARCE.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyDbContext _dbContext;

        public ProductRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ProductDto> AddAsync(ProductDto product)
        {
            return  await _dbContext.AddProductAsync(product);
        }

        public async Task<ProductDto> GetByIdAsync(int productId)
        {
            var result= await _dbContext.GetProductById(productId);
            if (result is null) {
                return null;
            
            }

            return new ProductDto { 
                ProductId = productId,
                Name = result.Name,
                Description = result.Description,
                Price = result.Price,
                Stock = result.Stock,
                Category = result.Category,
                Status = result.Status
            };
        }

        public async Task<List<ProductDto>> ListAsync()
        {
            var result = await _dbContext.GetAllProducts();

            return result.Select(p => new ProductDto
            {
                ProductId = p.ProductId,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                Stock = p.Stock,
                Category = p.Category,
                Status = p.Status
            }).ToList();
        }

        public async Task<ProductDto> UpdateAsync(ProductDto product)
        {
            return await _dbContext.UpdateProductAsync(product);

        }
    }
}
