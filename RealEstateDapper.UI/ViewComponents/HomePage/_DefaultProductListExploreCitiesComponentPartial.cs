﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace RealEstateDapper.UI.ViewComponents.HomePage
{
    public class _DefaultProductListExploreCitiesComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
