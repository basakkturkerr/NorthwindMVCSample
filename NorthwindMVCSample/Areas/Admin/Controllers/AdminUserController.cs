using NorthwindMVCSample.Models.ORM;
using NorthwindMVCSample.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindMVCSample.Areas.Admin.Controllers
{
    public class AdminUserController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();

        // GET: Admin/AdminUser
        public ActionResult Index()
        {
            List<AdminUserVM> model = db.AdminUsers.Select(q => new AdminUserVM()
            {
                ID = q.id,
                EMail = q.email,
                Password = q.password,
                Name = q.name,
                Surname = q.surname,
                LastLoginDate = q.lastlogindate,
            }).ToList();

            return View(model);
        }
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(AdminUser admin)
        {
            db.AdminUsers.Add(admin);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DeleteAdmin(int id)
        {
            AdminUser admin = db.AdminUsers.FirstOrDefault(q => q.id == id);
            db.AdminUsers.Remove(admin);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}