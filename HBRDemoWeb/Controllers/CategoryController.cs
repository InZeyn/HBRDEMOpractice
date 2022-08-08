using Microsoft.AspNetCore.Mvc;

namespace HBRDemoWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
