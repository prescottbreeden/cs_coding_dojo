using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using login2.Models;

namespace login2.Controllers
{
    public class LoginController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginUser userSubmission)
        {
            if(ModelState.IsValid)
            {
                System.Console.WriteLine("------------ Success -------------");
                System.Console.WriteLine(userSubmission.LoginEmail);
                System.Console.WriteLine("------------ Success -------------");
                return RedirectToAction("Index");
            }
            else
            {
                System.Console.WriteLine("------------le sigh------------");
                System.Console.WriteLine(userSubmission.LoginEmail);
                System.Console.WriteLine(userSubmission.LoginPassword);
                System.Console.WriteLine("------------le sigh------------");
                return View("Index", userSubmission);
            }
        }
    }
}
