using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using wedding_planner.Models;
using Microsoft.AspNetCore.Identity;

namespace wedding_planner.Controllers
{
  public class LoginController : Controller
    {
        private WeddingDb dbContext;
        public LoginController(WeddingDb context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("/register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                dbContext.CreateNewUser(user);
                return RedirectToAction("Index");
            }
            else 
            {
                return View("Index");
            }
        }

        [HttpPost("/proccesslogin")]
        public IActionResult ProccessLogin(LoginUser user)
        {
            if(ModelState.IsValid)
            {
                var result = dbContext.LoginValidation(user);
                if(result == "Success")
                {
                    var currentUser = dbContext.GetOneUser(user.LogEmail);
                    HttpContext.Session.SetInt32("user_id", 
                        currentUser.user_id);
                    return RedirectToAction("Dashboard");
                }
                return View("Index");
            }
            else 
            {
                return View("Index");
            }
        }

        [HttpGet("/logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [HttpGet("/dashboard")]
        public IActionResult Dashboard()
        {
            int? id = HttpContext.Session.GetInt32("user_id");
            if (id is null) return RedirectToAction("Index"); 
            List<Wedding> Model = dbContext.GetAllWeddings();
            return View(Model);
        }

    }
}
