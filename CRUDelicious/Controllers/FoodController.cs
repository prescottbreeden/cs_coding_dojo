using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CRUDelicious.Models;
using System.Linq;

namespace CRUDelicious.Controllers
{
    public class FoodController : Controller
    {
        private FoodContext dbContext;
        public FoodController(FoodContext context)
        {
            dbContext = context;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Dish> AllDishes = dbContext.dishes.ToList();
            ViewBag.all_dishes = AllDishes;
            return View();
        }

        [HttpPost("/new")]
        public IActionResult NewDish(Dish newDish)
        {
            dbContext.dishes.Add(newDish);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
