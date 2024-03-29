﻿using Shouldly;
using DomainProduct = CARCE.Domain.Product;

namespace CARCE.Domain.UnitTests.Product
{
    
    public class ProductTest
    {
        [Fact]
        public void Create_ShouldReturnNewProduct_WhenPassingAllValues()
        {
            //ARRANGE
            int productId = new Random().Next(1,100);
            string name = new Guid().ToString();
            int status = 1;
            int stock = 1;
            string description = "description";
            Decimal price = 1;
            int category =1;


            //ACT

            var newProduct = DomainProduct.Product.Create(productId,name,status,stock,description,price,category);


            //ASSERT

            newProduct.ShouldNotBe(null);
            newProduct.ProductId.ShouldBe(productId);
            newProduct.Name.ShouldBe(name);
            newProduct.Status.ShouldBe(status);
            newProduct.Stock.ShouldBe(stock);
            newProduct.Description.ShouldBe(description);
            newProduct.Price.ShouldBe(price);
            newProduct.Category.ShouldBe(category);
        }

        [Fact]
        public void Update_ShouldReturnModifiedProduct_WhenPassingModifiedValues()
        {
            //ARRANGE
            int productId = new Random().Next(1, 100);
            string name = new Guid().ToString();
            int status = 1;
            int stock = 1;
            string description = "description";
            Decimal price = 1;
            int category = 1;


            //ACT

            var newProduct = DomainProduct.Product.Create(productId, name, status, stock, description, price, category);

            DomainProduct.Product.Update(newProduct, name, status, stock*10, description, price*10, category);


            //ASSERT

            newProduct.ShouldNotBe(null);
            newProduct.ProductId.ShouldBe(productId);
            newProduct.Name.ShouldBe(name);
            newProduct.Status.ShouldBe(status);
            newProduct.Stock.ShouldBe(stock*10);
            newProduct.Description.ShouldBe(description);
            newProduct.Price.ShouldBe(price*10);
            newProduct.Category.ShouldBe(category);
        }

    }
}
