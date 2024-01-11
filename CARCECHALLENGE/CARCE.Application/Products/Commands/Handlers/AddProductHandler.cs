using CARCE.Application.Dtos;
using CARCE.Application.Interfaces;
using MediatR;

namespace CARCE.Application.Products.Commands.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, ProductDto>
    {
        private readonly IProductRepository _productRepository;

        public AddProductHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<ProductDto> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            return await _productRepository.AddAsync(request.Product);
        }
    }
}
