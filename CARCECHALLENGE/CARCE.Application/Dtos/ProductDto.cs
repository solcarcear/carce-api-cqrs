namespace CARCE.Application.Dtos
{
    public class ProductDto
    {
        public int ProductId { get;  set; }
        public string Name { get;  set; }
        public int Status { get;  set; }
        public int Stock { get;  set; }
        public string Description { get;  set; }
        public decimal Price { get;  set; }
        public int Category { get; set; }
        public int Discount { get; set; }
        public decimal FinalPrice => (Price * (100 - Discount)) / 100;

    }
}
