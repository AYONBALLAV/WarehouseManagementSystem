using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using WarehouseManagement.Application.Dtos;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Application.Services;

namespace WarehouseManagement.API.Controller;
[ApiController]
[Route("api/[controller]")]
    public class ProductController: ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

       /* public IActionResult Index()
        {
            return View();
        } */
       [HttpPost]
        public IActionResult CreateProduct([FromBody]
            CreateProductDto createProductDto)
        {
            var productDto = _productService.CreateProduct(createProductDto);
            return Ok(ProductDto);
        }
    }
