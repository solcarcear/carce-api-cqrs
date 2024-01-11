using CARCE.Application.Dtos;
using CARCE.Application.Interfaces;
using System.Text.Json;

namespace CARCE.Infrastructure.ThirdPartyApi
{
    public class DiscountService : IDiscountService
    {
        private readonly HttpClient _httpClient;

        public DiscountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<DiscountDto> GetDiscountByProductAsync(int idProduct)
        {
            try
            {
                var responseString = await _httpClient.GetStringAsync("/discounts");

                var discountList = JsonSerializer.Deserialize<List<DiscountDto>>(responseString);


                return discountList.FirstOrDefault(x => x.productId == idProduct);
            }
            catch (Exception ex)
            {

                return new DiscountDto();
            }
           
        }
    }
}
