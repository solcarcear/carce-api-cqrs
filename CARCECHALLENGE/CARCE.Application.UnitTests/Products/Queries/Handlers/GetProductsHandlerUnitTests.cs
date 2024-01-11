using CARCE.Application.Dtos;
using CARCE.Application.Interfaces;
using CARCE.Application.Products.Queries;
using CARCE.Application.Products.Queries.Handlers;
using FluentAssertions;
using Moq;

namespace CARCE.Application.UnitTests.Products.Queries.Handlers
{
    public class GetProductsHandlerUnitTests
    {
        private readonly Mock<IProductRepository> _productRepositoryMoq;

        public GetProductsHandlerUnitTests()
        {
            _productRepositoryMoq = new();
        }

        [Fact]
        public async Task Handle_Should_ReturnEmptyProductsList_WhenRepositoryIsEmpty() {

            //ARRANGE
            var query = new GetProductsQuery();
            _productRepositoryMoq.Setup(x=>x.ListAsync()).ReturnsAsync(new List<ProductDto>());

            var handler = new GetProductsHandler(_productRepositoryMoq.Object);

            //ACT

            var result = await handler.Handle(query, default);

            //ASSERT

            result.Should().BeEmpty();
        }

        [Fact]
        public async Task Handle_Should_ReturnProductsList_WhenRepositoryHasData()
        {

            //ARRANGE
            var query = new GetProductsQuery();
            var dataProductDto = new List<ProductDto> { new ProductDto(), new ProductDto() };
            _productRepositoryMoq.Setup(x => x.ListAsync()).ReturnsAsync(dataProductDto);

            var handler = new GetProductsHandler(_productRepositoryMoq.Object);

            //ACT

            var result = await handler.Handle(query, default);

            //ASSERT

            result.Should().NotBeNullOrEmpty();
            result.Should().Match(x=>x.Count()>1,"because the list has 2 items");
            result.Should().Match(x=>x.Count()==2,"because the list has 2 items");
        }




    }
}
