﻿using BaiTap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap.Controllers
{
    public class PersonController : Controller
    {
        LTQLdbContext db = new LTQLdbContext();
        
        // GET: Person
        public ActionResult Index()
        {
            return View(db.PerSons.ToList());
        }

        public ActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult Create(Person ps)
        {
            if(ModelState.IsValid)
            {
                db.PerSons.Add(ps);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ps);
        }
    }
}