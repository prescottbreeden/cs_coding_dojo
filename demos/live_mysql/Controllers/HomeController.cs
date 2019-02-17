using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using live_mysql.Models;

namespace live_mysql.Controllers
{
  public class HomeController : Controller
  {
    [Route("")]
    [HttpGet]
    public IActionResult Index()
    {
      List<Dictionary<string, object>> AllUsers = DbConnector.Query(@"
        SELECT * FROM users
      ");

      // To provide this data, we could use ViewBag or a View Model.  ViewBag shown here:
      ViewBag.Users = AllUsers;
      return View();
    }

    // Get One User
    [HttpGet]
    [Route("{userId}")]
    public IActionResult Show(int userId)
    {
      Dictionary<string, object> User = DbConnector.Query($@" SELECT FirstName, LastName FROM users WHERE id = {userId}" )[0];
    //   List<Dictionary<string, object>> Users = DbConnector.Query($"SELECT * FROM users WHERE id = {userId}");
    //   var user = Users[0];

      ViewBag.OneUser = User;
      return View();
    }

    // Create a User
    [HttpPost]
    [Route("create")]
    public IActionResult Create(User user)
    {
      // other code
      string query = $"INSERT INTO users (FirstName, LastName) VALUES ('{user.FirstName}', '{user.LastName}')";
      DbConnector.Execute(query);
      // other code

      return RedirectToAction("Index");
    }

  }
}
