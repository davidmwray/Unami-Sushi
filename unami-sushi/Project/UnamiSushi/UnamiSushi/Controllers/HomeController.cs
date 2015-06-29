using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UnamiSushi.DAL;
using UnamiSushi.Models;

namespace UnamiSushi.Controllers
{
    public class HomeController : Controller
    {
        private PrimaryContext db = new PrimaryContext();
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Admin()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Menu()
        {
            return View(db.MenuCategories);
        }

        // GET: MenuCategory/Details/5
        [AllowAnonymous]
        public ActionResult Details(int? id)
        {
            //if (id == null)
            //{
            //    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            //}
            MenuCategory menuCategory = db.MenuCategories.Find(id);
            if (menuCategory == null)
            {
                return HttpNotFound();
            }
            return View(menuCategory);
        }
        
     
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [ChildActionOnly]
        [AllowAnonymous]
        public ActionResult CategoryPartialDetails(int? id)
        {
            var model = db.MenuCategories.Find(id);

            return PartialView("Details", model);
        }
    }
}