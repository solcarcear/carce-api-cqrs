using CARCE.Application.Dtos;
using CARCE.Application.Products.Commands;
using CARCE.Application.Products.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CARCE.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _mediator.Send(new GetProductsQuery());

            return Ok(products);
        }
        /// <summary>
        /// Obtiene un producto en base al ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id:int}", Name = "GetProductById")]
        public async Task<ActionResult> GetProductById(int id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));
            if (product is null) { 
                return NotFound($"Not found product:{id}");
            }

            return Ok(product);
        }
        /// <summary>
        /// Adiciona un producto
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> AddProduct([FromBody] ProductDto product)
        {
            var productToReturn = await _mediator.Send(new AddProductCommand(product));

            return Created("GetProductById", productToReturn);
        }

        /// <summary>
        /// Actualiza un producto existente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPut("{id:int}")]
        public async Task<ActionResult> UpdateProduct(int id, [FromBody] ProductDto product)
        {
            product.ProductId = id;
            var productToReturn = await _mediator.Send(new UpdateProductCommand(product));

            return Ok(productToReturn);
        }
    }
}
