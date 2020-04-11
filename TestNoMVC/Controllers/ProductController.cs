using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestNoMVC.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestNoMVCModels;

namespace TestNoMVC.Controllers
{
    //the route control 
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public ProductController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }

        public JsonFileProductService ProductService { get;  }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }

        
    }
}