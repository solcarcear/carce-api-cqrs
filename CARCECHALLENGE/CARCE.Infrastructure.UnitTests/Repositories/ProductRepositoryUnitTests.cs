using CARCE.Application.Dtos;
using CARCE.Infrastructure.Repositories;
using FluentAssertions;

namespace CARCE.Infrastructure.UnitTests.Repositories
{
    public class ProductRepositoryUnitTests
    {

        private MyDbContext _myDbContextMoq;

        public ProductRepositoryUnitTests()
        {
            _myDbContextMoq = new();
        }


        [Fact]
        public async Task ListAsync_Should_ReturnProductList_WhenContextHasData()
        {

            //ARRANGE
            _myDbContextMoq = new();
            var myRepo = new ProductRepository(_myDbContextMoq);

            //ACT

            var result = await myRepo.ListAsync();

            //ASSERT

            result.Should().NotBeEmpty();


        }


        [Fact]
        public async Task GetByIdAsync_Should_ReturnProductDto_WhenContextHasData()
        {

            //ARRANGE
            _myDbContextMoq = new();
            var myRepo = new ProductRepository(_myDbContextMoq);

            //ACT

            var result = await myRepo.GetByIdAsync(1);

            //ASSERT

            result.Should().NotBeNull();


        }



        [Fact]
        public async Task AddAsync_Should_ReturnProductDto_WhenProductIsAdded() {

            //ARRANGE
            _myDbContextMoq = new();
            var myRepo = new ProductRepository(_myDbContextMoq);

            //ACT

            var result = await myRepo.AddAsync(new ProductDto());

            //ASSERT

            result.Should().NotBeNull();
            

        }

        [Fact]
        public async Task UpdateAsync_Should_ReturnProductDto_WhenProductIsUpdated()
        {

            //ARRANGE
            _myDbContextMoq = new();
            var myRepo = new ProductRepository(_myDbContextMoq);

            //ACT

            var result = myRepo.UpdateAsync(new ProductDto());

            //ASSERT

            result.Should().NotBeNull();

        }
    }
}
