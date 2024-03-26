using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.ViewComponents.HomePage
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
