using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoreFunWithFunctions.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MoreFunWithFunctions.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
           
            _logger = logger;
            _logger.Log(LogLevel.Information, $"Constructor ran at {DateTime.Now.ToShortTimeString()}");
        }

        public IActionResult Index()
        {
            _logger.Log(LogLevel.Information, $"Index action ran at {DateTime.Now.ToShortTimeString()}");
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
