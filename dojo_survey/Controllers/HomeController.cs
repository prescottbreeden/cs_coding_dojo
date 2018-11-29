using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojo_survey.Models;

namespace dojo_survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/process")]
        public IActionResult Process(
                string Name, 
                string DojoLocation, 
                string FavoriteLanguage,
                string Comment
            )
        {
            System.Console.WriteLine("================");
            System.Console.WriteLine("{0}, {1}, {2}", 
                Name, DojoLocation, FavoriteLanguage, Comment);
            System.Console.WriteLine("================");

            return RedirectToAction("Result");
        }

        [HttpGet]
        [Route("/result")]
        public IActionResult Result()
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
