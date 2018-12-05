using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lost.Models;
using lost.Factory;

namespace lost.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrailFactory trailFactory;
        public HomeController()
        {
            //Instantiate a UserFactory object that is immutable (READONLY)
            //This establishes the initial DB connection for us.
            trailFactory = new TrailFactory();
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            //We can call upon the methods of the userFactory directly now.
            ViewBag.all_trails = trailFactory.FindAll();
            return View();
        }

        [HttpPost]
        [Route("/new")]
        public IActionResult NewTrail(Trail newTrail)
        {
            trailFactory.Add(newTrail);
            return RedirectToAction("Index");
        }

    }
}