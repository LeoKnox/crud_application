using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BigProject.Models;

namespace BigProject.Controllers
{
    public class LogRegController : Controller
    {
        private BigProjectContext dbContext;

        public LogRegController(BigProjectContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [Route("createuser")]
        [HttpPost]
        public IActionResult CreateUser(User newUser)
        {
            if (ModelState.IsValid)
            {
                dbContext.CreateUser(newUser, HttpContext);
                return RedirectToAction("Dashboard", "Big");
            }
            else
            {
                return View("Index");
            }
        }

        [Route("loginuser")]
        [HttpPost]
        public IActionResult LoginUser(Login newLogin)
        {
            if (ModelState.IsValid)
            {
                dbContext.LoginUser(newLogin, HttpContext);
                return RedirectToAction("Dashboard", "Big");
            }
            else
            {
                return View("Index");
            }
        }
    }
}
