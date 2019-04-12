using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoDachi.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace DojoDachi.Controllers
{
  public class HomeController : Controller
  {
    public Instructor prescott { get; set; }

    [HttpGet("")]
    public IActionResult Index()
    {
      string sesh = HttpContext.Session.GetString("Instructor-Dachi");
      if (sesh is null)
      {
        prescott = new Instructor();
        HttpContext.Session.SetString("Instructor-Dachi", JsonConvert.SerializeObject(prescott));
      }
      else
      {
        prescott = JsonConvert.DeserializeObject<Instructor>(sesh);
      }

      return View(prescott);
    }

    [HttpGet("play")]
    public IActionResult Play()
    {
      string sesh = HttpContext.Session.GetString("Instructor-Dachi");
      if (sesh is null)
        return RedirectToAction("Index");

      else
      {
        prescott = JsonConvert.DeserializeObject<Instructor>(sesh);
        prescott.Play();
        HttpContext.Session.SetString("Instructor-Dachi", JsonConvert.SerializeObject(prescott));
      }

      return RedirectToAction("Index");
    }

    [HttpGet("feed")]
    public IActionResult Feed()
    {
      string sesh = HttpContext.Session.GetString("Instructor-Dachi");
      if (sesh is null)
        return RedirectToAction("Index");

      else
      {
        prescott = JsonConvert.DeserializeObject<Instructor>(sesh);
        prescott.Feed();
        HttpContext.Session.SetString("Instructor-Dachi", JsonConvert.SerializeObject(prescott));
      }

      return RedirectToAction("Index");
    }

    [HttpGet("sleep")]
    public IActionResult Sleep()
    {
      string sesh = HttpContext.Session.GetString("Instructor-Dachi");
      if (sesh is null)
        return RedirectToAction("Index");

      else
      {
        prescott = JsonConvert.DeserializeObject<Instructor>(sesh);
        prescott.Sleep();
        HttpContext.Session.SetString("Instructor-Dachi", JsonConvert.SerializeObject(prescott));
      }

      return RedirectToAction("Index");
    }

    [HttpGet("work")]
    public IActionResult Work()
    {
      string sesh = HttpContext.Session.GetString("Instructor-Dachi");
      if (sesh is null)
        return RedirectToAction("Index");

      else
      {
        prescott = JsonConvert.DeserializeObject<Instructor>(sesh);
        prescott.Work();
        HttpContext.Session.SetString("Instructor-Dachi", JsonConvert.SerializeObject(prescott));
      }

      return RedirectToAction("Index");
    }


  }
}
