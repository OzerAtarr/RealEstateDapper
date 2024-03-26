using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.ViewComponents.Layout
{
    public class _NavbarViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
