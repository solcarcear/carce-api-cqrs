using CARCE.Domain.Product;

namespace CARCE.Application.Interfaces
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<List<Product>> ListAsync();
        Task<Product> GetByIdAsync(int productId);
    }
}
