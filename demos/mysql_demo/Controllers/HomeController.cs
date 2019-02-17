using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mysql_demo.Models;

namespace mysql_demo.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
            ViewBag.Users = AllUsers;
            return View();
        }

        [HttpGet]
        [Route("{userId}")]
        public IActionResult Show(int userId)
        {
            Dictionary<string, object> User = DbConnector.Query($"SELECT * FROM users WHERE id = {userId}")[0];
            // Other code
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
