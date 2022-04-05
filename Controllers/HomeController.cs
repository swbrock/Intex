using Intex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace Intex.Controllers
{
    public class HomeController : Controller
    {
        //private DBContext context { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Analysis()
        {
            return View();
        }

        public IActionResult MapAnalysis(string county)
        {
            //var accidents = context.Accidents
            //    .Include("Team")
            //    .Where(x => x.County == county || County == null)
            //    .ToList();

            return View();
        }

        public IActionResult DriveSafe()
        {
            return View();
        }
    }
}
