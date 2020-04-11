using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using TestNoMVC.WebSite.Services;
using TestNoMVCModels;

namespace TestNoMVC.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public JsonFileProductService ProductService;

        //Calls the list of products to this page and hold it in the virable.
        public IEnumerable<Product> Products { get; private set; }

        //this Contructor is calling the service in the argument
        public IndexModel(ILogger<IndexModel> logger,
            JsonFileProductService productService)
        {

            _logger = logger;
            ProductService = productService;
        }

        //on a get request Get the products 
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
