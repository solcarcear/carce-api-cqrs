using CARCE.Application.Dtos;

namespace CARCE.Application.Interfaces
{
    public interface IProductRepository
    {
        Task AddAsync(ProductDto product);
        Task UpdateAsync(ProductDto product);
        Task<List<ProductDto>> ListAsync();
        Task<ProductDto> GetByIdAsync(int productId);
    }
}
