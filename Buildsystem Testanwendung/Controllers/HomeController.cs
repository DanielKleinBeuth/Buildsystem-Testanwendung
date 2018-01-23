using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Buildsystem_Testanwendung;

namespace Buildsystem_Testanwendung.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var summe = new TestableCode().Add(2, 3);
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}
