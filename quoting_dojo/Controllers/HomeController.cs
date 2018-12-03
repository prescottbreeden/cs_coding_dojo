using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using quoting_dojo.Models;

namespace quoting_dojo.Controllers
{
    public class HomeController : Controller
    {
        private readonly QuoteFactory _quoteFactory;
        public HomeController(QuoteFactory qFactory)
        {
            _quoteFactory = qFactory;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            _quoteFactory.FindAll();
            ViewBag.AllQuotes = _quoteFactory.AllQuotes;
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
