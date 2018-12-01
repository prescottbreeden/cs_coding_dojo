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
            Dojodachi dojo = GetDojodachi();
            return View(dojo);
        }

        [HttpGet("/feed")]
        public IActionResult Feed()
        {
            Dojodachi dojo = GetDojodachi();
            dojo.Feed();
            SaveDojodachi(dojo);
            return RedirectToAction("Index");
        }

        [HttpGet("/play")]
        public IActionResult Play()
        {
            Dojodachi dojo = GetDojodachi();
            dojo.Play();
            SaveDojodachi(dojo);
            return RedirectToAction("Index");
        }

        [HttpGet("/work")]
        public IActionResult Work()
        {
            Dojodachi dojo = GetDojodachi();
            dojo.Work();
            SaveDojodachi(dojo);     
            return RedirectToAction("Index");
        }

        [HttpGet("/sleep")]
        public IActionResult Sleep()
        {
            Dojodachi dojo = GetDojodachi();
            dojo.Sleep();
            SaveDojodachi(dojo);
            return RedirectToAction("Index");
        }

        [HttpGet("/reset")]
        public IActionResult Reset()
        {
            Dojodachi dojo = new Dojodachi();
            SaveDojodachi(dojo);
            return RedirectToAction("Index");
        }

        public Dojodachi GetDojodachi()
        {
            string dd = HttpContext.Session.GetString("dachi");
            if (dd == null)
            {
                Dojodachi dojo = new Dojodachi();
                HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));
                return dojo;
            }
            else 
            {
                Dojodachi dojo = JsonConvert.DeserializeObject<Dojodachi>(dd);
                return dojo;
            }
        }
        public void SaveDojodachi(Dojodachi dojo) 
        {
            HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
