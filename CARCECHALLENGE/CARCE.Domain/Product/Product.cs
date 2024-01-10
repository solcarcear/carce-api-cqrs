﻿namespace CARCE.Domain.Product
{
    public sealed class Product
    {
        private Product(int productId, string name, int status, int stock, string description, decimal price, int category)
        {
            ProductId = productId;
            Name = name;
            Status = status;
            Stock = stock;
            Description = description;
            Price = price;
        }

        public int ProductId { get; private set; }
        public string Name { get; private set; }
        public int Status { get; private set; }
        public int Stock { get; private set; }
        public string Description { get; private set; }
        public Decimal Price { get; private set; }
        public int Category { get; private set; }


        public static Product Create(int productId, string name, int status, int stock, string description, decimal price, int category) {
            return new Product(productId,name,status,stock,description,price,category);
        }


      

    }
}