using CARCE.Application.Dtos;

namespace CARCE.Application.Interfaces
{
    public interface IDiscountService
    {
        Task<DiscountDto> GetDiscountByProductAsync(int idProduct);
    }
}
