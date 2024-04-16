using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
