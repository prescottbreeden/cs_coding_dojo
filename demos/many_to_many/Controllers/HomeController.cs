using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using many_to_many.Models;
using Microsoft.EntityFrameworkCore;

namespace many_to_many.Controllers
{
  public class HomeController : Controller
    {
        private ManyContext dbContext;
        public HomeController(ManyContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            List<Person> allPersons = dbContext.Persons.ToList();
            List<Magazine> allMagazines = dbContext.Magazines.ToList();
            PersonsMagazines model = new PersonsMagazines();
            model.people = allPersons;
            model.mags = allMagazines;

            return View(model);
        }

        [Route("{personId}")]
        [HttpGet]
        public IActionResult Lookup(int personId)
        {
            var data = dbContext.Persons
                .Include(p => p.Subscriptions)
                .ThenInclude(s => s.Magazine)
                .FirstOrDefault(p => p.PersonId == personId);

            System.Console.WriteLine("\n===========================\n");
            System.Console.WriteLine(data.Name + " data... ");
            System.Console.WriteLine("\n===========================\n");
            return View(data);
        }

    }
}
