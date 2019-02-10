using Microsoft.AspNetCore.Mvc;

namespace angular.Controllers
{
  [Route("api/[controller]")]
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json("All users");
        }

        [HttpGet("int:id")]
        public IActionResult GetOne(int id)
        {
            return Json($"Getting user {id}");
        }
    }
}
