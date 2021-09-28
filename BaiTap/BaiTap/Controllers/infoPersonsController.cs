using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BaiTap.Models;

namespace BaiTap.Controllers
{
    public class infoPersonsController : Controller
    {
        private LTQLdbContext db = new LTQLdbContext();
        AutogenKey strPro = new AutogenKey();

        // GET: infoPersons
        public ActionResult Index()
        {
            return View(db.InfoPeople.ToList());
        }

        // GET: infoPersons/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            infoPerson infoPerson = db.InfoPeople.Find(id);
            if (infoPerson == null)
            {
                return HttpNotFound();
            }
            return View(infoPerson);
        }

        // GET: infoPersons/Create
        public ActionResult Create()
        {
            string newID = "";

            var emp = db.InfoPeople.ToList().OrderByDescending(m => m.PersonID);
            if(emp.Count()==0)
            {
                newID = "PERS0001";
            }    
            else {
                newID  = strPro.AutogenerateKey(emp.FirstOrDefault().PersonID);
            }
            ViewBag.newPerID = newID;
                 return View();
        }

        // POST: infoPersons/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PersonID,PersonName,address,Sex,Description")] infoPerson infoPerson)
        {
            if (ModelState.IsValid)
            {
                db.PerSons.Add(infoPerson);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(infoPerson);
        }

        // GET: infoPersons/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            infoPerson infoPerson = db.InfoPeople.Find(id);
            if (infoPerson == null)
            {
                return HttpNotFound();
            }
            return View(infoPerson);
        }

        // POST: infoPersons/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PersonID,PersonName,address,Sex,Description")] infoPerson infoPerson)
        {
            if (ModelState.IsValid)
            {
                db.Entry(infoPerson).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(infoPerson);
        }

        // GET: infoPersons/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            infoPerson infoPerson = db.InfoPeople.Find(id);
            if (infoPerson == null)
            {
                return HttpNotFound();
            }
            return View(infoPerson);
        }

        // POST: infoPersons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            infoPerson infoPerson = db.InfoPeople.Find(id);
            db.PerSons.Remove(infoPerson);
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
