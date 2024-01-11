using CARCE.Application.Dtos;
using CARCE.Domain.Product;

namespace CARCE.Infrastructure
{
    public class MyDbContext
    {
        private static List<Product> _products = new();

        public MyDbContext()
        {

            _products.Add(Product.Create(1,"Product 1",1,10,"",100,3));
            _products.Add(Product.Create(2,"Product 2",1,10,"",100,3));
            _products.Add(Product.Create(3,"Product 3",0,10,"",100,1));
            _products.Add(Product.Create(4,"Product 4",0,10,"",100,2));
            _products.Add(Product.Create(5,"Product 5",1,10,"",100,1));

            _products.Add(Product.Create(6, "Product 6", 0, 10, "", 100, 3));
            _products.Add(Product.Create(7, "Product 7", 1, 10, "", 100, 4));
            _products.Add(Product.Create(8, "Product 8", 1, 10, "", 100, 4));
            _products.Add(Product.Create(9, "Product 9", 1, 10, "", 100, 2));
            _products.Add(Product.Create(10, "Product 10", 1, 10, "", 100, 1));

            _products.Add(Product.Create(11, "Product 11", 1, 10, "", 100, 1));
            _products.Add(Product.Create(12, "Product 12", 0, 10, "", 100, 3));
            _products.Add(Product.Create(13, "Product 13", 0, 10, "", 100, 3));
            _products.Add(Product.Create(14, "Product 14", 1, 10, "", 100, 4));
            _products.Add(Product.Create(15, "Product 15", 1, 10, "", 100, 2));

            _products.Add(Product.Create(16, "Product 16", 0, 10, "", 100, 1));
            _products.Add(Product.Create(17, "Product 17", 1, 10, "", 100, 5));
            _products.Add(Product.Create(18, "Product 18", 1, 10, "", 100, 2));
            _products.Add(Product.Create(19, "Product 19", 1, 10, "", 100, 5));
            _products.Add(Product.Create(20, "Product 20", 0, 10, "", 100, 2));

        }


        public async Task<ProductDto> AddProductAsync(ProductDto product) {
            var idGenerated = _products.Max(x => x.ProductId)+1;
            _products.Add(Product.Create(idGenerated,
                product.Name,
                product.Status,
                product.Stock,
                product.Description,
                product.Price,
                product.Category));
            product.ProductId = idGenerated;
            return product;
        }

        public async Task<ProductDto> UpdateProductAsync(ProductDto product)
        {
            var productPersisted = await GetProductById(product.ProductId);

            Product.Update(productPersisted,
                product.Name,
                product.Status,
                product.Stock,
                product.Description,
                product.Price,
                product.Category);

            return product; 
        }

        public async Task<IEnumerable<Product>> GetAllProducts() => await Task.FromResult(_products);

        public async Task<Product> GetProductById(int id) =>
            await Task.FromResult(_products.FirstOrDefault(p => p.ProductId == id));



    }
}
