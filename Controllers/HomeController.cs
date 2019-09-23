using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net;


using Microsoft.AspNetCore.Mvc;


using SampleDotNetCoreMVCApp.Models;

namespace SampleDotNetCoreMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = RuntimeInformation.OSDescription + " " + RuntimeInformation.OSArchitecture.ToString();
            ViewData["HostName"] = Dns.GetHostName();
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
