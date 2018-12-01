using demo_prep.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_prep.Controllers
{
  public class AwesomeController : Controller
  {
    [HttpGet]
    [Route("")]
    public IActionResult Index()
    {
      // query the database => static class
      // query the db => pass into view
      // User bugs = UserFactory.NewUser("Bugs Bunny", "bugs@gmail.com", "seattle");

      return View();
    }

    [HttpPost]
    [Route("/users")]
    public IActionResult NewUser(string name, string email, string location)
    {
      UserFactory.NewUser(name, email, location);

      return RedirectToAction("Index");
    }

    // [HttpGet]
    // [Route("/test")]
    // public IActionResult Test(User newUser)
    // {
    //   ViewBag.userName = newUser.Name;
    //   return View();
    // }

    // [HttpGet]
    // [Route("/test2")]
    // public IActionResult Test2(string name, string email, string location)
    // {
    //   ViewBag.name = name;
    //   return View("test");
    // }
  }
}