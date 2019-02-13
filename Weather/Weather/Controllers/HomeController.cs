using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weather.Models;

namespace Weather.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["app_id"] = "7f7f869d7f96ec68638df4b60d5e9f6f";
            
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Welcome to Weather";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Please do not contact us.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
