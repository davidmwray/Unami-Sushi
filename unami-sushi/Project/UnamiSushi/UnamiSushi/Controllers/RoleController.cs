using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using UnamiSushi.Models;
using UnamiSushi.DAL;

namespace UnamiSushi.Controllers
{
    public class RoleController : Controller
    {
        ApplicationDbContext context;

        public RoleController ()
        {
            context = new ApplicationDbContext();
        }

        /// Get All Roles
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);
        }

        /// Create  a New role
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }


        /// Create a New Role
        [HttpPost]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Admin", "Home");
        }

    }
}