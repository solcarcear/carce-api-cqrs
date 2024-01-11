using CARCE.Application.Dtos;
using CARCE.Application.Interfaces;
using CARCE.Application.Products.Commands.Handlers;
using CARCE.Application.Products.Commands;
using Moq;
using FluentAssertions;

namespace CARCE.Application.UnitTests.Products.Commands.Handlers
{
    public class UpdateProductHandlerUnitTests
    {
        private readonly Mock<IProductRepository> _productRepositoryMoq;

        public UpdateProductHandlerUnitTests( )
        {
            _productRepositoryMoq = new();
        }

        [Fact]
        public async Task Handle_Should_ReturnAProduct_WhenARecordIsUpdated()
        {
            //ARRANGE
            var command = new UpdateProductCommand(new ProductDto());
            _productRepositoryMoq.Setup(x => x.UpdateAsync(It.IsAny<ProductDto>())).ReturnsAsync(new ProductDto());

            var handler = new UpdateProductHandler(_productRepositoryMoq.Object);

            //ACT

            var result = await handler.Handle(command, default);

            //ASSERT

            result.Should().NotBeNull();

        }
    }
}
