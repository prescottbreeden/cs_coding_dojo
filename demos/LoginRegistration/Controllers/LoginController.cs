using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;
using Microsoft.AspNetCore.Identity;

namespace LoginRegistration.Controllers
{
  public class LoginController : Controller
  {
    private DemoContext dbContext;

    public LoginController(DemoContext context)
    {
      dbContext = context;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost("register")]
    public IActionResult Register(Registration form)
    {
      if (ModelState.IsValid)
      {
        User newUser = new User()
        {
          FirstName = form.FirstName,
          LastName = form.LastName,
          Email = form.Email,
          Password = form.Password
        };
        PasswordHasher<User> Hasher = new PasswordHasher<User>();
        newUser.Password = Hasher.HashPassword(newUser, newUser.Password);

        dbContext.Users.Add(newUser);
        dbContext.SaveChanges();

        return View("Success", newUser);
      }
      else
      {
        return View("Index");
      }
    }


    [HttpPost("login")]
    public IActionResult Login(Login form)
    {
      if (ModelState.IsValid)
      {
        User userInDb = dbContext.Users.FirstOrDefault(u => u.Email == form.LoginEmail);

        if (userInDb is null)
        {
          ModelState.AddModelError("Email", "Invalid Email/Password");
          return View("Index");
        }

        else
        {
          var hasher = new PasswordHasher<Login>();
          var result = hasher.VerifyHashedPassword(form, userInDb.Password, form.LoginPassword);
          if (result == 0)
          {
            ModelState.AddModelError("Email", "Invalid Email/Password");
            return View("Index");
          }
          return View("Success", userInDb);
        }
      }
      return View("Index");
    }

  }
}
