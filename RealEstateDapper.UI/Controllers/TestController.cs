using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
