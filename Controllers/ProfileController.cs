﻿using Microsoft.AspNetCore.Mvc;

namespace PainAssessment.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
