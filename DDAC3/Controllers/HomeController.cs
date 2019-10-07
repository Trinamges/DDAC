using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DDAC3.Models;

namespace DDAC3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            ViewData["Message"] = "Welcome to the Book Management System";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is the Book Management System that helps manage book stock and orders";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Details";

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
