using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using models.Models;

namespace models.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {

            User bugs = new User("Bugs Bunny", 22);
            bugs.LuckyNumbers.Add(7);
            bugs.LuckyNumbers.Add(17);
            User elmer = new User("Elmer Fud", 40);
            User coyote = new User("Wile E. Coyote", 16);
            List<User> allUsers = new List<User>();
            allUsers.Add(bugs);
            allUsers.Add(elmer);
            allUsers.Add(coyote);


            Stack csharp = new Stack();
            csharp.Language = "C#";
            csharp.Students.Add(bugs);
            csharp.Students.Add(elmer);
            csharp.Students.Add(coyote);

            return View("Index", csharp);
        }

    }
}
