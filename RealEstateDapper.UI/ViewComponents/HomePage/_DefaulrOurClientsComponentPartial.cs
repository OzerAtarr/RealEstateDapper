using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.ViewComponents.HomePage
{
    public class _DefaulrOurClientsComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
