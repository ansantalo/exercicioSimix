using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ExercicioSimix.Models;

namespace ExercicioSimix.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult Index(string firstName, string lastName)
        {
            String numbers = "";

            for (int i = 1; i <= 200; i++)
            {
                if (i % 15 == 0)
                    numbers += "Z ";
                else if (i % 5 == 0)
                    numbers += "Y ";
                else if (i % 3 == 0)
                    numbers += "X ";
                else
                    numbers += i + " ";
            }

            if (numbers.Length > 1)
                numbers = numbers.Remove(numbers.Length - 1, 1);

            ViewBag.Numbers = numbers;
            return View();
        }
    }
}
