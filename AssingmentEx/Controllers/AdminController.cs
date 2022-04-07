using AssingmentEx.Authorizations;
using AssingmentEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssingmentEx.Areas
{
    public class AdminController : Controller
    {
        companycontext db = new companycontext();
        // GET: Admin
        [AdminAuth]
        public ActionResult Index()
        {

            return View(this.db.Users.ToList());
        }
        public ActionResult details(Int64 id)
        {
            var v = this.db.Users.Find(id);
            return View(v);
        }
        [HttpGet]
        public ActionResult Edit(Int64 id)
        {
            var v = this.db.Users.Find(id);
            return View(v);
        }
        public ActionResult Edit(User rec)
        {
            this.db.Entry(rec).State = System.Data.Entity.EntityState.Modified;
            this.db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Delete(Int64 id)
        {
            var v = this.db.Users.Find(id);
            this.db.Users.Remove(v);
            this.db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}

     

  