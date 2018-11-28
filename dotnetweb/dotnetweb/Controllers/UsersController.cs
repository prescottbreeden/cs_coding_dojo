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
        public string Index()
        {
            return "Welcome user...";
        }

        [HttpGet]
        [Route("/users/{id}")]
        public string GetUsers(string id)
        {
            return $"Getting user {id}..";
        }

        [HttpGet]
        [Route("/users")]
        public string GetAll()
        {
            return "Getting all users..";
        }

        [HttpPost]
        [Route("/users")]
        public IActionResult AddUser()
        {
            return Redirect("");
        }

    }
}