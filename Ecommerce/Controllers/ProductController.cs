using Ecommerce.Models;
using Ecommerce.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAllProducts()
        {
            List<Product> products = await _productRepository.GetAllProducts();
            return Ok(products);
        }
        
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            Product product = await _productRepository.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> AddProduct ([FromBody] Product productModel)
        {
            Product product = await _productRepository.AddProduct(productModel);

            return Ok(product);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Product>> UpdateProduct([FromBody] Product productModel,int id)
        {
            productModel.Id = id;
            Product product = await _productRepository.UpdateProduct(productModel,id);

            return Ok(product);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<bool>> DeleteProduct(int id)
        {
            bool product = await _productRepository.DeleteProduct(id);

            return Ok(product);
        }
    }
}