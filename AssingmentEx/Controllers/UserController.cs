using AssingmentEx.Authorizations;
using AssingmentEx.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssingmentEx.Controllers
{
    public class UserController : Controller
    {
        companycontext db = new companycontext();
        // GET: User
        [UserAuth]
        [OutputCache(Duration = 0, VaryByParam = "none", NoStore = true)]
        public ActionResult Index()
        { 
            return View();
        }
        [HttpGet]
        public ActionResult UserRegistration()
        {

            return View();
        }
        [HttpPost]
        public ActionResult UserRegistration(RegistrationVM Vm)
        {
            if (ModelState.IsValid)
            {
                User v = new User();
                v.FirstName = Vm.FirstName;
                v.LastName = Vm.LastName;
                v.EmailId = Vm.EmailId;
                v.DateOfBirth = Vm.DateOfBirth;
                v.Password = Vm.Password;
                this.db.Users.Add(v);
                this.db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(Vm);
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginVM lvm)
        {

            if (ModelState.IsValid)
            {
                var v = this.db.Users.SingleOrDefault(p => p.EmailId == lvm.EmailId && p.Password == lvm.Password);
                if (v != null)
                {
                    Session["UserId"] = v.UserId;
                    Session["FirstName"] = v.FirstName;
                    Session["LastName"] = v.LastName;
                    DateTime loginuserDOB = v.DateOfBirth;
                    DateTime CurrentDate = DateTime.Now;
                    int Age = CurrentDate.Year - loginuserDOB.Year;
                    Session["age"] = Age;
                     return RedirectToAction("Index");
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