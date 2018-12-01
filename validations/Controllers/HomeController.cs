using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using validations.Models;

namespace validations.Controllers
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
        public IActionResult CreateNew(User user)
        {
            if(ModelState.IsValid)
            {
                User newUser = UserFactory.NewUser(user);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
