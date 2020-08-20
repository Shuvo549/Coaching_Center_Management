using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoachingCenterManagement.DataContext;
using CoachingCenterManagement.Models;

namespace CoachingCenterManagement.Controllers
{
    public class HomeController : Controller
    {
        CoachingCenterDbContext db = new CoachingCenterDbContext();

        public ActionResult HomePage()
        {
            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(Registers reg)
        {
            if(ModelState.IsValid)
            {
                db.Registers.Add(reg);
                db.SaveChanges();
                return RedirectToAction("Registration");
            }
            return RedirectToAction("Registration");
        }
    }
}