using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
