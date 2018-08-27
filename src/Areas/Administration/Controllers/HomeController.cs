﻿using Microsoft.AspNetCore.Mvc;

namespace NetCoreAppAreas.Areas.Administration.Controllers
{
    [Area("Administration")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}