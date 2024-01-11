using CARCE.Application.Dtos;
using MediatR;

namespace CARCE.Application.Products.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<ProductDto>>;
}
