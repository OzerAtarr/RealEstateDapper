using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
