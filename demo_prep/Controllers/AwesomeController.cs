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

    [HttpPost]
    [Route("/users")]
    public IActionResult NewUser(User user)
    {
      UserFactory.NewUser(user);

      return RedirectToAction("Index");
    }

  }
}