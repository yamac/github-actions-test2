﻿using Core.Example;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExampleService _exampleService;

        public HomeController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        public IActionResult Index()
        {
            ViewBag.CurrentTime = _exampleService.GetCurrentTime();
            return View();
        }
    }
}
