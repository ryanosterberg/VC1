using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class DatesActivityController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: DateTime.Now);
        }
        [HttpPost]
        public ActionResult DateMagic(DateTime inputBirthday)
        {
            return View(viewName: "Index", model: inputBirthday);
        }
        public ActionResult Presidential()
        {
            return View(viewName: "Index", model: DateTime.Now);
        }
        [HttpPost]
        public ActionResult SayPresidential(DateTime inputBirthday)
        {
            return View(viewName: "Index", model: inputBirthday);
        }
    }
}

