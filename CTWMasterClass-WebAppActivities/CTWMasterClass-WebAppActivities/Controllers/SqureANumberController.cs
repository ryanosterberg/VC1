using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class SqureANumberController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: -10.99);
        }
        [HttpPost]
        public ActionResult SaySquare(double inputNumber)
        {
            return View(viewName: "Index", model: (Math.Sqrt(inputNumber)));
        }

    }
}