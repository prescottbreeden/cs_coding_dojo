using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using validations.Models;
using validations.Factory;

namespace validations.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewBag.all_quotes = QuoteFactory.FindAll();
            return View();
        }

        [HttpPost]
        [Route("/add_author")]
        public IActionResult NewAuthor(Author author)
        {
            if(ModelState.IsValid)
            {
                AuthorFactory.NewAuthor(author);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost]
        [Route("/add_quote")]
        public IActionResult NewQuote(Quote quote)
        {
            if(ModelState.IsValid)
            {
                QuoteFactory.NewQuote(quote);
                return RedirectToAction("Index");
            }
            else
            {
                return View("Index");
            }
        }
    }
}
