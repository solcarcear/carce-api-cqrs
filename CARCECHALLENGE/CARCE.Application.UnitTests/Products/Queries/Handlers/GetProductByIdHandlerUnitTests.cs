using CARCE.Application.Dtos;
using CARCE.Application.Interfaces;
using CARCE.Application.Products.Queries;
using CARCE.Application.Products.Queries.Handlers;
using FluentAssertions;
using Moq;

namespace CARCE.Application.UnitTests.Products.Queries.Handlers
{
    public class GetProductByIdHandlerUnitTests
    {
        private readonly Mock<IProductRepository> _productRepositoryMoq;

        public GetProductByIdHandlerUnitTests()
        {
            _productRepositoryMoq = new();
        }
        [Fact]
        public async Task Handle_Should_ReturnAProduct_WhenRepositoryHasARecord()
        {

            //ARRANGE
            var query = new GetProductByIdQuery(1);
            _productRepositoryMoq.Setup(x => x.GetByIdAsync(It.IsAny<int>())).ReturnsAsync(new ProductDto());

            var handler = new GetProductByIdHandler(_productRepositoryMoq.Object);

            //ACT

            var result = await handler.Handle(query, default);

            //ASSERT

            result.Should().NotBeNull();
        }
        [Fact]
        public async Task Handle_Should_ReturnNull_WhenRepositoryHasNoRecord()
        {

            //ARRANGE
            var query = new GetProductByIdQuery(1);
            _productRepositoryMoq.Setup(x => x.GetByIdAsync(It.IsAny<int>()));

            var handler = new GetProductByIdHandler(_productRepositoryMoq.Object);

            //ACT

            var result = await handler.Handle(query, default);

            //ASSERT

            result.Should().BeNull();
        }
    }
}
