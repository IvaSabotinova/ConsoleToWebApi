using ConsoleToWebApi.Models;
using ConsoleToWebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;
        private readonly IProductRepository productRepository1;
        public ProductController(IProductRepository productRepository, IProductRepository productRepository1)
        {
            this.productRepository = productRepository;
            this.productRepository1 = productRepository1;

        }
        [HttpPost("")]
        public IActionResult AddProduct([FromBody]ProductModel product)
        {
            productRepository.AddProduct(product);
            List<ProductModel> products = productRepository1.GetAllProducts();
            return Ok(products);
        }
    }
}
