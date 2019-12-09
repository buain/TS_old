using MVCInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestSystem.DAL.Entities;

namespace MVCInterface.Controllers
{
    public class TestController : Controller
    {
        // GET:
        UserContext db = new UserContext();
        public ActionResult TestsList()
        {
            IEnumerable<Models.Test> tests = db.Tests;
            ViewBag.Tests = tests;
            return View();
        }
        //GET:
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }
        //POST:
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(Models.Test model)
        {
            if (ModelState.IsValid)
            {
                Models.Test.Create(model);
                return RedirectToAction("TestsList");
            }

            return View(model);
        }
    }
}