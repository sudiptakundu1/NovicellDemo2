using BusinessLogic;
using Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductLogic _business;

        public ProductController(IProductLogic business)
        {
            _business = business;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {

            var products = _business.getAllProducts();

            return Ok(products);
        }

        [HttpGet("{productId}")]
        public IActionResult GetProductById(int productId)
        {

            var product = _business.getProductById(productId);

            return Ok(product);
        }

        [HttpGet("since/{datetime}")]
        public IActionResult GetProductsSinceTimeStamp(string datetime)
        {

            var products = _business.getProductByTimeStamp(Convert.ToDateTime(datetime));

            return Ok(products);
        }
    }
}
