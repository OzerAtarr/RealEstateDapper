﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutSpinnerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
