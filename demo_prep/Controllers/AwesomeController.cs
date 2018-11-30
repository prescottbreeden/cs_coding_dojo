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
      return View();
    }

    [HttpGet]
    [Route("/test")]
    public IActionResult Test(User newUser)
    {
      ViewBag.userName = newUser.Name;
      return View();
    }

    [HttpGet]
    [Route("/test2")]
    public IActionResult Test2(string name, string email, string location)
    {
      ViewBag.name = name;
      return View("test");
    }

    [HttpPost]
    [Route("/users")]
    public IActionResult NewUser(string name, string email, string location)
    {
      // UserFactory.NewUser(name, email, location);

      return RedirectToAction("Test2", new { name = name, email = email, lcoation = location });
    }
  }
}