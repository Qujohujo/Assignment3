using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment3.Models;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ApplicationResponse appResponse)
        {
            if (appResponse.title == "Independence Day")
            {
                ModelState.AddModelError(string.Empty, "That is an invalid movie title.");
                return View(/*"Movies"*/);
            }
            else if (ModelState.IsValid)
            {
                TempStorage.AddMovie(appResponse);
                return View();
            }
            else
            {
                return View();
            }
            
        }

        public IActionResult Movies()
        {
            return View(TempStorage.MovieAdditions);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
