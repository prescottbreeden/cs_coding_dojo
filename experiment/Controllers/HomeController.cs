using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using dojodachi.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace dojodachi.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("")]
    public IActionResult Index()
    {

      HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));
      // DateTime start = DateTime.Now;
      // Dojodachi dojo = GetDojodachi();
      // DateTime end = DateTime.Now;
      // System.Console.WriteLine("===================");
      // System.Console.WriteLine(start-end);
      // System.Console.WriteLine("===================");
      return View(DojodachiHelper.dojo);
    }


    [HttpGet("/feed")]
    public IActionResult Feed()
    {
      DojodachiHelper.Feed();
      return RedirectToAction("Index");
    }

    [HttpGet("/play")]
    public IActionResult Play()
    {
      DojodachiHelper.Play();
      return RedirectToAction("Index");
    }

    [HttpGet("/work")]
    public IActionResult Work()
    {
      DojodachiHelper.Work();
      return RedirectToAction("Index");
    }

    [HttpGet("/sleep")]
    public IActionResult Sleep()
    {
      DojodachiHelper.Sleep();
      return RedirectToAction("Index");
    }

    [HttpGet("/reset")]
    public IActionResult Reset()
    {
      DojodachiHelper.NewDojodachi();
      return RedirectToAction("Index");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
