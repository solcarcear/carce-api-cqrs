using CARCE.Application.Dtos;
using CARCE.Application.Interfaces;
using CARCE.Application.Products.Commands;
using CARCE.Application.Products.Commands.Handlers;
using FluentAssertions;
using Moq;

namespace CARCE.Application.UnitTests.Products.Commands.Handlers
{
    public class AddProductHandlerUnitTests
    {
        private readonly Mock<IProductRepository> _productRepositoryMoq;

        public AddProductHandlerUnitTests()
        {
            _productRepositoryMoq = new();
        }

        [Fact]
        public async Task Handle_Should_ReturnAProduct_WhenARecordIsAdded()
        {
            //ARRANGE
            var command = new AddProductCommand(new ProductDto());
            _productRepositoryMoq.Setup(x => x.AddAsync(It.IsAny<ProductDto>())).ReturnsAsync(new ProductDto());

            var handler = new AddProductHandler(_productRepositoryMoq.Object);

            //ACT

            var result = await handler.Handle(command, default);

            //ASSERT

            result.Should().NotBeNull();

        }
    }
}
