using CARCE.Application.Dtos;
using CARCE.Application.Interfaces;
using MediatR;

namespace CARCE.Application.Products.Commands.Handlers
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, ProductDto>
    {
        private readonly IProductRepository _productRepository;

        public UpdateProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDto> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            return await _productRepository.UpdateAsync(request.Product);
        }
    }
}
