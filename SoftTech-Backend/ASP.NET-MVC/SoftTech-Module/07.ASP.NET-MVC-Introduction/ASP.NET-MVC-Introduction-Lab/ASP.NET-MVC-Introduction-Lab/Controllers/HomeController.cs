﻿using ASP.NET_MVC_Introduction_Lab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NET_MVC_Introduction_Lab.Controllers
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

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }
       
        public ActionResult Numbers(int count = 5)
        {
            ViewBag.Count = count;
            return View();
        }

        public ActionResult Files()
        {
            string path = @"C:\";
            List<string> files = Directory
                .GetDirectories(path)
                .ToList();
            files.AddRange(Directory.GetFiles(path));

            return View(files);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}