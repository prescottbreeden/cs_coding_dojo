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
            ViewBag.users = UserFactory.AllUsers;
            return View();
        }

        [HttpPost]
        [Route("/process")]
        public IActionResult Process(string Name, string DojoLocation, string FavoriteLanguage, string Comment)
        {
            UserFactory.CreateUser(Name, DojoLocation, FavoriteLanguage, Comment);

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
