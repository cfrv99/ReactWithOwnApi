using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReactSimple.WebApi.Domain.Entities;
using ReactSimple.WebApi.Services;

namespace ReactSimple.WebApi.Controllers
{
    
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpGet("/api/products/{categoryId?}")]
        public IActionResult GetAllProducts(int? categoryId)
        {
            var products = productService.GetProducts();
            if (categoryId > 0)
            {
                 products = productService.GetProductsByCategory(categoryId);
            }
            return Ok(products);
        }
        [HttpPost("/api/products")]
        public IActionResult AddProduct(Product product)
        {
            bool status = productService.Add(product);
            if (status)
            {
                return Ok();
            }
            return BadRequest();
        }
     
        

    }
}