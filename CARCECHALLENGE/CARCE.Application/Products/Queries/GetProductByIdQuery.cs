using CARCE.Application.Dtos;
using MediatR;

namespace CARCE.Application.Products.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<ProductDto>;
}
