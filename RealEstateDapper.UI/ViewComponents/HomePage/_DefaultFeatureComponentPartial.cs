﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstateDapper.UI.ViewComponents.HomePage
{
    public class _DefaultFeatureComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
