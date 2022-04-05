using Intex.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Intex.Controllers
{
    public class HomeController : Controller
    {
        private IAccidentsRepository repo { get; set; }

        public HomeController(IAccidentsRepository temp)
        {
            repo = temp;
        }

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
            //var accidents = repo.crashes.ToList();
                

            return View();
        }

        public IActionResult MapAnalysis(string county)
        {
            //var accidents = repo.Accidents
            //    .Where(x => x.COUNTY_NAME == county || county == null)
            //    .ToList();

            return View();
        }

        public IActionResult DriveSafe()
        {
            return View();
        }
    }
}
