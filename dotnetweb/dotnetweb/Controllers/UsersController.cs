using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnetweb.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/users/{id}")]
        public IActionResult GetUsers(string id)
        {
            return Json($"Getting user {id}..");
        }

        [HttpGet]
        [Route("/users")]
        public IActionResult GetAll()
        {
            return Json("Getting all users..");
        }

        [HttpPost]
        [Route("/users")]
        public IActionResult AddUser()
        {
            return RedirectToAction("Index");
        }

    }
}
