using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using validations.Models;

namespace validations.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {

            int? counter = HttpContext.Session.GetInt32("Counter");
            if(counter == null) 
            {
               counter = 1;
               HttpContext.Session.SetInt32("Counter", (int)counter);
            }
            else
            {
                ++counter;
                HttpContext.Session.SetInt32("Counter", (int)counter);
            }

            HttpContext.Session.SetString("Name", "Bob");
            string userName = HttpContext.Session.GetString("Name");
            ViewBag.Name = userName;
            ViewBag.Counter = counter;

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
