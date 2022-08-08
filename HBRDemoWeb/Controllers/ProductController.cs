using HBRDemoApp.Models;
using HBRDemoApp.Modules;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HBRDemoWeb.Controllers
{
    public class ProductController : Controller
    {
        public ProductController()
        {

        }

        public async Task<IActionResult> GetProductsAsync()
        {
            var productModule = new ProductModule();
            var response = await productModule.GetProducts();
            return View(response);
        }
    }
}
