using CARCE.Application.Dtos;
using MediatR;

namespace CARCE.Application.Products.Commands
{
    public record UpdateProductCommand(ProductDto Product) : IRequest<ProductDto>;
}
