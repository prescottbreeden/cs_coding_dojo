using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using passcode.Models;

namespace passcode.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("")]
    public IActionResult Index()
    {
      int? counter = HttpContext.Session.GetInt32("Counter");
      if (counter == null) 
      {
        counter = 1;
        HttpContext.Session.SetInt32("Counter", (int)counter);
      }
      else
      {
        HttpContext.Session.SetInt32("Counter", (int)++counter);
      }
      Passcode newCode = new Passcode();
      ViewBag.Counter = counter;
      ViewBag.Code = newCode.Code;
      return View("index");
    }

    [HttpPost("/new")]
    public IActionResult New()
    {
      return RedirectToAction("Index");
    }
  }
}