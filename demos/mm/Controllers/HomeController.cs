using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mm.Models;

namespace mm.Controllers
{
    public class HomeController : Controller
    {
        private mmContext dbContext;
        public HomeController(mmContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Person> allPersons = dbContext.Persons.ToList();
            List<Magazine> allMags = dbContext.Magazines.ToList();

            return View(allPersons);
        }

        [Route("{personId}")]
        [HttpGet]
        public IActionResult GetOne(int personId)
        {
            Person person = dbContext.Persons
                .Include(p => p.Subscriptions)
                .ThenInclude(s => s.Magazine)
                .FirstOrDefault(u => u.PersonId == personId);

            return View(person);
        }



    }
}
