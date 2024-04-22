using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.Controllers
{
    public class WhoWeAreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
