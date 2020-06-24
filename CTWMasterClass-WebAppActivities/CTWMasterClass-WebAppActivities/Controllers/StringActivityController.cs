using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class StringActivityController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: "All sdhlsdlsdjlsfklstarts here.");
        }
        [HttpPost]
        public ActionResult SayHello(string inputString)
        {
            return View(viewName: "Index", model: "Hello world " + inputString);
        }

    }
}