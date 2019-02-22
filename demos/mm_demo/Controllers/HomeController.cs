using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mm_demo.Models;

namespace mm_demo.Controllers
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
      return View(allPersons);
    }

    [HttpGet("{personId}")]
    public IActionResult GetOne(int personId)
    {
        Person person = dbContext.Persons
            .Include(p => p.Subscriptions)
            .ThenInclude(s => s.Magazine)
            .FirstOrDefault(p => p.PersonId == personId);

        return View(person);
    }

  }
}
