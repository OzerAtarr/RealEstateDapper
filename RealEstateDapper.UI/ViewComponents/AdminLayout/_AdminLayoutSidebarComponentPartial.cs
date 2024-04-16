using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
