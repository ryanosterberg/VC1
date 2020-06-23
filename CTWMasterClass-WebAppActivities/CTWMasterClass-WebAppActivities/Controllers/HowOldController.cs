using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class HowOldController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult HowOld(DateTime birthday)
        {
            int yearNow = DateTime.Now.Year;
            int yearThen = birthday.Year;
            int age = yearNow - yearThen;
            if (birthday.AddYears(age)> DateTime.Now)
                age--;
            return View(viewName: "Index", model: age);
        }
    }
}