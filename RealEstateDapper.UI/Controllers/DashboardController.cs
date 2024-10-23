using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
