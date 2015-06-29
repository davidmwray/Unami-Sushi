using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UnamiSushi.DAL;
using UnamiSushi.Models;

namespace UnamiSushi.Controllers
{
    public class MenuPictureController : Controller
    {
        private PrimaryContext db = new PrimaryContext();

        // GET: MenuPicture
        public ActionResult Index()
        {
            return View(db.MenuPictures.ToList());
        }

        // GET: MenuPicture/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuPicture menuPicture = db.MenuPictures.Find(id);
            if (menuPicture == null)
            {
                return HttpNotFound();
            }
            return View(menuPicture);
        }

        // GET: MenuPicture/Create
        public ActionResult Create()
        {
            ViewBag.MenuItemID = new SelectList(db.MenuItems, "MenuItemID", "MenuItemName");

            return View();
        }

        // POST: MenuPicture/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MenuItemID, PictureName")] MenuPicture menuPicture, HttpPostedFileBase file1, HttpPostedFileBase file2, string PictureName)
        {
            if (ModelState.IsValid)
            {

            //    file1.SaveAs(HttpContext.Server.MapPath("~/Photos/Normal"));
            //    file2.SaveAs(HttpContext.Server.MapPath("~/Photos/Normal"));

                var File1 = Path.GetFileName(file1.FileName);
                var FileName1 = Path.GetFileNameWithoutExtension(file1.FileName);
                string FileType1 = Path.GetExtension(File1);

                //string FullName1 = FileName1 + FileType1;
                string FullName1 = PictureName + FileType1;

                //var path1 = Path.Combine(HttpContext.Server.MapPath("~/Photos/Normal"), FileName1, FileType1);

                string path1 = "~/Photos/Normal/" + FullName1;



                var File2 = Path.GetFileName(file2.FileName);
                var FileName2 = Path.GetFileNameWithoutExtension(file2.FileName);
                string FileType2 = Path.GetExtension(File2);

                //string FullName2 = FileName2 + "Thumb" + FileType2;
                string FullName2 = PictureName + "Thumb" + FileType2;

                //var path2 = Path.Combine(HttpContext.Server.MapPath("~/Photos/Normal"), FileName2, "Thumb", FileType2);

                string path2 = "~/Photos/Normal/" + FullName2;



                file1.SaveAs(HttpContext.Server.MapPath(path1));
                file2.SaveAs(HttpContext.Server.MapPath(path2));



                menuPicture.PicturePathname = path1;
                menuPicture.ThumbnailPathname = path2;

                db.MenuPictures.Add(menuPicture);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuPicture);
        }

        // GET: MenuPicture/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuPicture menuPicture = db.MenuPictures.Find(id);
            if (menuPicture == null)
            {
                return HttpNotFound();
            }
            return View(menuPicture);
        }

        // POST: MenuPicture/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PictureID,PictureItem,PicturePathname,ThumbnailPathname")] MenuPicture menuPicture)
        {
            if (ModelState.IsValid)
            {
                db.Entry(menuPicture).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menuPicture);
        }

        // GET: MenuPicture/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MenuPicture menuPicture = db.MenuPictures.Find(id);
            if (menuPicture == null)
            {
                return HttpNotFound();
            }
            return View(menuPicture);
        }

        // POST: MenuPicture/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MenuPicture menuPicture = db.MenuPictures.Find(id);
            db.MenuPictures.Remove(menuPicture);
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
