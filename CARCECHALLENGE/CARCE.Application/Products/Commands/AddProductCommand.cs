using CARCE.Application.Dtos;
using MediatR;

namespace CARCE.Application.Products.Commands
{
    public record AddProductCommand(ProductDto Product) : IRequest<ProductDto>;
}
