using Microsoft.AspNetCore.Mvc;
using awesome_project;

namespace awesome_project.Controllers
{
  public class AwesomeController : Controller   
  {
    [HttpGet]      
    [Route("")]    
    public IActionResult Index()
    {
      return View("index");
    }

    [HttpGet]       
    [Route("/users")]   
    public IActionResult AllUsers(string username, string useremail)
    {
      System.Console.WriteLine(username);
      System.Console.WriteLine(useremail);
      ViewBag.UserName = username;
      ViewBag.UserEmail = useremail;
      
      return View("newuser");
    }

    [HttpPost]      
    [Route("/users")] 
    public IActionResult NewUser(string name, string email)
    {
      System.Console.WriteLine("=========================");
      System.Console.WriteLine($"{name} {email}");
      System.Console.WriteLine("=========================");
      return RedirectToAction("AllUsers", new { username = name, useremail = email});
    }
  }
}