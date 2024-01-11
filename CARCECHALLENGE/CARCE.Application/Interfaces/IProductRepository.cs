using CARCE.Application.Dtos;

namespace CARCE.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductDto> AddAsync(ProductDto product);
        Task<ProductDto> UpdateAsync(ProductDto product);
        Task<List<ProductDto>> ListAsync();
        Task<ProductDto> GetByIdAsync(int productId);
    }
}
