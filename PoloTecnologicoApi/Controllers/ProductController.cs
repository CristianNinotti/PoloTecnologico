using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Models.Dtos.Request;
using Web.Models.Dtos.Response;
using Web.Services.Interfaces;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET /api/product
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<ProductResponseDto> products = await _productService.GetAllAsync();
            return Ok(products);
        }

        // GET /api/product/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductResponseDto>> Get([FromQuery] int id)
        {
            ProductResponseDto product = await _productService.GetByIdAsync(id);
            if (product == null)
                return NotFound();

            return Ok(product);
        }
        // POST /api/product
        [HttpPost]
        public async Task<ActionResult<ProductResponseDto>> Post([FromBody] ProductRequestDto dto)
        {
            ProductResponseDto product = await _productService.CreateAsync(dto);
            return Ok(product);
        }
    }

}
