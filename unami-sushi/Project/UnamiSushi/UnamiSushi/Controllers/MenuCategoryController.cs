using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UnamiSushi.DAL;
using UnamiSushi.Models;

namespace UnamiSushi.Controllers
{
    public class MenuCategoryController : Controller
    {
        private PrimaryContext db = new PrimaryContext();

        // GET: MenuCategory
        public ActionResult Index()
        {
            return View(db.MenuCategories.ToList());
        }

        // GET: MenuCategory/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //MenuCategory menuCategory = db.MenuCategories.Find(id); //Working original code

            //MenuCategory menuCategory = db.MenuCategories.Include(i => i.MenuItems.Select(x => x.ItemGallery).First()).Find(id); //Needs confirmation
            //var menuQuery = db.MenuCategories.Include(i => i.MenuItems.Select(x => x.ItemGallery)); //Needs confirmation
            //MenuCategory menuCategory = db.MenuCategories.Find()

            //var MenuCategories = db.MenuCategories.Include(i => i.MenuItems.Select(x => x.ItemGallery.Select(y => y.PicturePathname)));
            var menuCategories = db.MenuCategories.Include("SubCategories.MenuItems.MenuPictures");
            var itemGallery = db.MenuItems.First().MenuPictures;
            //var MenuCategories = db.MenuCategories.Include();

            MenuCategory menuCategory = (from c in menuCategories where c.CategoryID == id select c).FirstOrDefault();

            if (menuCategory == null)
            {
                return HttpNotFound();
            }
            return View(menuCategory);
        }

        // GET: MenuCategory/Details/5
        public ActionResult DetailsPartial(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var menuCategories = db.MenuCategories.Include("MenuItems.MenuPictures");

            var itemGallery = db.MenuItems.First().MenuPictures;

            MenuCategory menuCategory = (from c in menuCategories where c.CategoryID == id select c).FirstOrDefault();

            if (menuCategory == null)
            {
                return HttpNotFound();
            }
            return View(menuCategory);
        }

        // GET: MenuCategory/Create
        public ActionResult Create()
        {
            

            return View();
        }

        // POST: MenuCategory/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryID,CategoryName,CategoryDescription")] MenuCategory menuCategory)
        {
            if (ModelState.IsValid)
            {
                db.MenuCategories.Add(menuCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuCategory);
        }

        // GET: MenuCategory/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuCategory menuCategory = db.MenuCategories.Find(id);
            if (menuCategory == null)
            {
                return HttpNotFound();
            }
            return View(menuCategory);
        }

        // POST: MenuCategory/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryID,CategoryName,CategoryDescription")] MenuCategory menuCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menuCategory);
        }

        // GET: MenuCategory/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuCategory menuCategory = db.MenuCategories.Find(id);
            if (menuCategory == null)
            {
                return HttpNotFound();
            }
            return View(menuCategory);
        }

        // POST: MenuCategory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuCategory menuCategory = db.MenuCategories.Find(id);
            db.MenuCategories.Remove(menuCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
