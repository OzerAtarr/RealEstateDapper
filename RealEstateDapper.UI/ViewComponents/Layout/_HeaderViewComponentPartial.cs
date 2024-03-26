using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.ViewComponents.Layout
{
    public class _HeaderViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
