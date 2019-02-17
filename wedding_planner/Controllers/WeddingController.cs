using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using wedding_planner.Models;

namespace wedding_planner.Controllers
{
  public class WeddingController: Controller
    {
        private WeddingDb dbContext;
        public WeddingController(WeddingDb context)
        {
            dbContext = context;
        }
        [HttpGet("/new")]
        public IActionResult CreateWedding()
        {
            int? id = HttpContext.Session.GetInt32("user_id");
            if (id is null) return RedirectToAction("Index"); 
            ViewBag.userId = id;
            return View();
        }

        [HttpPost("/process")]
        public IActionResult ProccessWedding(NewWedding wedding)
        {
            int? id = HttpContext.Session.GetInt32("user_id");
            if (id is null) return RedirectToAction("Index"); 

            if(ModelState.IsValid)
            {
                dbContext.CreateNewWedding(wedding);
                return RedirectToAction("Dashboard");
            }
            else 
            {
                ViewBag.userId = id;
                return View("CreateWedding");
            }
        }
        
    }
}
