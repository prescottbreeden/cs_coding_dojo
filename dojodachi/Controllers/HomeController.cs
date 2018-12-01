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
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string dd = HttpContext.Session.GetString("dachi");
            if (dd == null)
            {
                Dojodachi dojo = new Dojodachi();
                HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));
                return View(dojo);
            }
            else 
            {
                Dojodachi dojo = JsonConvert.DeserializeObject<Dojodachi>(dd);
                return View(dojo);
            }
        }

        [HttpPost]
        [Route("feed")]
        public IActionResult Feed()
        {
            string dd = HttpContext.Session.GetString("dachi");
            Dojodachi dojo = JsonConvert.DeserializeObject<Dojodachi>(dd);
            if(dojo.Meals > 0) 
            {
                Random rand = new Random();
                dojo.Fullness += rand.Next(5, 10);
                dojo.Meals--;
                HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));

                return RedirectToAction("Index");
            }
            else {
                dojo.Meals = 0;
                string err = "Meals cannot drop below 0, better put your Dachi to work!";
                ViewBag.Error = err;

                return View("Index");
            }
        }

        [HttpPost]
        [Route("play")]
        public IActionResult Play()
        {
            string dd = HttpContext.Session.GetString("dachi");
            Dojodachi dojo = JsonConvert.DeserializeObject<Dojodachi>(dd);
            if(dojo.Happiness > 0)
            {
                Random rand = new Random();
                dojo.Meals += rand.Next(1, 3);
                dojo.Energy -= 5;
                HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));

                return RedirectToAction("Index");
            }
            else {
                string err = "Meals cannot drop below 0, better put your Dachi to work!";
                ViewBag.Error = err;

                return View("Index");
            }
        }

        [HttpPost]
        [Route("work")]
        public IActionResult Work()
        {
            if(ModelState.IsValid)
            {
                string dd = HttpContext.Session.GetString("dachi");
                Dojodachi dojo = JsonConvert.DeserializeObject<Dojodachi>(dd);
                Random rand = new Random();
                dojo.Meals += rand.Next(1, 3);
                dojo.Energy -= 5;
                HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));
                return RedirectToAction("Index");
            }
            else return View("Index");
        }

        [HttpPost]
        [Route("sleep")]
        public IActionResult Sleep()
        {
            string dd = HttpContext.Session.GetString("dachi");
            Dojodachi dojo = JsonConvert.DeserializeObject<Dojodachi>(dd);
            dojo.Energy += 15;
            dojo.Fullness -= 5;
            dojo.Happiness -= 5;
            HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
