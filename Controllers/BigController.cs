using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using BigProject.Models;

namespace BigProject.Controllers
{
    public class BigController : Controller
    {
        private BigProjectContext dbContext;

        public BigController(BigProjectContext context)
        {
            dbContext = context;
        }

        [Route("dashboard")]
        [HttpGet]
        public IActionResult Dashboard()
        {
            int? id = HttpContext.Session.GetInt32("uid");
            if (id is null) return RedirectToAction("Index", "LogReg");
            User oneuser = dbContext.Users.FirstOrDefault(u => u.UserId == id);
            List<Activities> AllActives = dbContext.Activities
            .Include(person => person.Attendee)
            .ThenInclude(use => use.User)
            .ToList();
            ViewBag.user = oneuser;
            ViewBag.act = AllActives;
            return View("Dashboard");
        }

        [Route("createactivity")]
        [HttpGet]
        public IActionResult CreateActivity()
        {
            int? id = HttpContext.Session.GetInt32("uid");
            if (id is null) return RedirectToAction("Index", "LogReg");
            return View("CreateActivity");
        }

        [Route("newactivity")]
        [HttpPost]
        public IActionResult NewActivity(Activities newActive)
        {
            int? uid = HttpContext.Session.GetInt32("uid");
            if (uid is null) return RedirectToAction("Index", "LogReg");
            if (ModelState.IsValid) {
                int? id = HttpContext.Session.GetInt32("uid");
                newActive.Coordinator = (int)id;
                dbContext.Add(newActive);
                dbContext.SaveChanges();
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("CreateActivity");
            }
        }

        [Route("joinact/{actId}")]
        [HttpGet]
        public IActionResult joinact(int actId)
        {
            Guest g = new Guest();
            int? x = HttpContext.Session.GetInt32("uid");
            g.UserId = (int)x;
            g.ActivityId = actId;
            dbContext.Add(g);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [Route("leaveact/{actId}")]
        [HttpGet]
        public IActionResult leaveact(int actId)
        {
            Guest g = dbContext.Guests
                .FirstOrDefault(gu => gu.ActivityId == actId);
            dbContext.Guests.Remove(g);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [Route("oneact/{actId}")]
        [HttpGet]
        public IActionResult oneact(int actId)
        {
            int? id = HttpContext.Session.GetInt32("uid");
            if (id is null) return RedirectToAction("Index", "LogReg");
            User oneuser = dbContext.Users.FirstOrDefault(u => u.UserId == id);
            ViewBag.co = oneuser;
            Activities anact = dbContext.Activities
                .Where(ac => ac.ActivityId == actId)
                .Include(guest => guest.Attendee)
                .ThenInclude(person => person.User)
                .FirstOrDefault();
            return View("One", anact);
        }

        [Route("deleteme/{actId}")]
        [HttpGet]
        public IActionResult deleteme(int actId)
        {
            Activities dact = dbContext.Activities
                .FirstOrDefault(d => d.ActivityId == actId);
            dbContext.Activities.Remove(dact);
            dbContext.SaveChanges();
            return RedirectToAction("Dashboard");
        }

        [Route("logout")]
        [HttpGet]
        public IActionResult logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "LogReg");
        }
    }
}