using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lost_in_the_woods.Models;
using lost_in_the_woods.Factory;

namespace lost_in_the_woods.Controllers
{
  public class HomeController : Controller
  {
    public readonly TrailFactory trailFactory;
    public HomeController()
    {
      trailFactory = new TrailFactory();
    }

    [HttpGet("")]
    public IActionResult Index()
    {
      ViewBag.alltrails = trailFactory.FindAll();
      return View();
    }

    [HttpPost("new")]
    public IActionResult NewTrail(Trail trail)
    {
      trailFactory.Add(trail);
      return RedirectToAction("Index");
    }
  }
}
