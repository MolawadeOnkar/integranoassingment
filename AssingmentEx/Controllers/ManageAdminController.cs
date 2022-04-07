using AssingmentEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssingmentEx.Controllers
{
    public class ManageAdminController : Controller
    {
        companycontext db = new companycontext();
        // GET: ManageAdmin
        [HttpGet]
        public ActionResult AdminRegistration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminRegistration(RegistrationVM Vm)
        {
            if (ModelState.IsValid)
            {
                AdminUser v = new AdminUser();
                v.FirstName = Vm.FirstName;
                v.LastName = Vm.LastName;
                v.EmailId = Vm.EmailId;
                v.DateOfBirth = Vm.DateOfBirth;
                v.Password = Vm.Password;
                this.db.AdminUsers.Add(v);
                this.db.SaveChanges();
                return RedirectToAction("AdminLogin");
            }
            return View(Vm);
        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(LoginVM lvm)
        {

            if (ModelState.IsValid)
            {
                var v = this.db.AdminUsers.SingleOrDefault(p => p.EmailId == lvm.EmailId && p.Password == lvm.Password);
                if (v != null)
                {
                    Session["AdminUserId"] = v.AdminUserId;
                    Session["FirstName"] = v.FirstName;
                    Session["LastName"] = v.LastName;
                    return RedirectToAction("Index","admin");
                }
                else
                {
                    ModelState.AddModelError("", "envalid emailid and password");
                    return View(lvm);
                }

            }
            return View(lvm);

        }

    }
}