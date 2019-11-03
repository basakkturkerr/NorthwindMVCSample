using NorthwindMVCSample.Models.ORM;
using NorthwindMVCSample.Models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthwindMVCSample.Areas.Admin.Controllers
{
    public class AdminCategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        public ActionResult Index()
        {
            List<CategoryVM> model = db.Categories.Select(q => new CategoryVM()
            {
                ID = q.CategoryID,
                Name = q.CategoryName,
                Description = q.Description
            }).ToList();

            return View(model);
        }
    }
}