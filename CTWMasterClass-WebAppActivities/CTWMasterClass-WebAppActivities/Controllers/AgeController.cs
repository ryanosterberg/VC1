using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class AgeController : Controller
    {
        // GET: Age
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        public ActionResult LastNameAge(String lastname, int age)
        {
            int value = Math.Abs(lastname.Length - age);
            return View(viewName: "Index", model: value);
        }
        public ActionResult LastNameAge(String lastname, int age)
        {
            int value = Math.Abs(lastname.Length - age);
            return View(viewName: "Index", model: value);
        }
    }
}