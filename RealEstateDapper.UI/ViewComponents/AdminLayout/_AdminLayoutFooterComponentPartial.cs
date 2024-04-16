using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
