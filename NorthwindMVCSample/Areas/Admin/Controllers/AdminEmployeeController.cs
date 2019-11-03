using NorthwindMVCSample.Models.ORM;
using NorthwindMVCSample.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindMVCSample.Areas.Admin.Controllers
{
    public class AdminEmployeeController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Admin/AdminEmployee
        public ActionResult Index()
        {
            List<EmployeeVM> model = db.Employees.Select(q => new EmployeeVM()
            {
                ID = q.EmployeeID,
                FirstName = q.FirstName,
                LastName = q.LastName,
                Address=q.Address,                
                Region = q.Region,
                City = q.City
            }).ToList();

            return View(model);
        }

        public ActionResult DeleteEmployee(int id)
        {
            Employee employee = db.Employees.FirstOrDefault(q => q.EmployeeID == id);
            db.Employees.Remove(employee);
            db.SaveChanges();

            return RedirectToAction("index");
        }
    }
}