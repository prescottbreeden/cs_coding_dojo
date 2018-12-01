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
            Dojodachi dojo = GetDojodachi();
            dojo.UpdateImage();
            return View(dojo);
        }

        [HttpGet]
        [Route("/feed")]
        public IActionResult Feed()
        {
            Dojodachi dojo = GetDojodachi();
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
                string err = "You have no more food to feed Dachi. Better put your Dachi to work!";
                ViewBag.Error = err;

                return View("Index", dojo);
            }
        }

        [HttpGet]
        [Route("/play")]
        public IActionResult Play()
        {
            Dojodachi dojo = GetDojodachi();
            if(dojo.Energy > 0)
            {
                Random rand = new Random();
                dojo.Happiness += rand.Next(5, 10);
                dojo.Energy -= 5;
                HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));

                return RedirectToAction("Index");
            }
            else {
                string err = "Oh no! Dojodachi has collapsed from exhaustion!";
                ViewBag.Error = err;

                return View("Index", dojo);
            }
        }

        [HttpGet]
        [Route("/work")]
        public IActionResult Work()
        {
            Dojodachi dojo = GetDojodachi();
            if(dojo.Energy > 0)
            {
                Random rand = new Random();
                dojo.Meals += rand.Next(1, 3);
                dojo.Energy -= 5;
                HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));
                return RedirectToAction("Index");
            }
            else return View("Index", dojo);
        }

        [HttpGet]
        [Route("/sleep")]
        public IActionResult Sleep()
        {
            Dojodachi dojo = GetDojodachi();
            if (dojo.Fullness > 0 || dojo.Happiness > 0) {
                dojo.Energy += 15;
                dojo.Fullness -= 5;
                dojo.Happiness -= 5;
                HttpContext.Session.SetString("dachi", JsonConvert.SerializeObject(dojo));

                return RedirectToAction("Index");
            }
            else return View("Index", dojo);
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
