using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpeckleWebsite.Models;

namespace SpeckleWebsite.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ActionResult Registration(int id=0)
        {
            User_Detail userModel = new User_Detail();
            return View(userModel);
        }
        [HttpPost]
        public ActionResult Registration(User_Detail userModel)
        {
            using (SpeckleDB speckleDB = new SpeckleDB())
            {
                speckleDB.Users.Add(userModel);
                speckleDB.SaveChanges();
            }
            ModelState.Clear();
            ViewBag.SuccessMessage = "Registration Successful.";
            return View("Registration", new User_Detail());
        }
    }
}