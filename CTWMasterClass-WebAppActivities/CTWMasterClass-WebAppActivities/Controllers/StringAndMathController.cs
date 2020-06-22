using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class StringAndMathController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult NameAndAgeDiff(String lastName, int age)
        {
            int nameLength = lastName.Length;
            int diff = age - nameLength;
            if (diff < 0) diff = diff * -1;
            return View(viewName: "Index", model: diff);
        }
    }
}