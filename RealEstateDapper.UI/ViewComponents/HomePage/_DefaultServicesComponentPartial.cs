﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.ViewComponents.HomePage
{
    public class _DefaultServicesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
