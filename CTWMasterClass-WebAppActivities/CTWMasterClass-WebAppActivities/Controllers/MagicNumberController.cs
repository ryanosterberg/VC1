using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class MagicNumberController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult MagicNum(int value1, int value2)
        { 
            if (value1 == null || value2 == null)
            {
                return View(viewName: "Index", model: -999);
            }
            if (value1 > value2)
            {
                int test = value1;
                value1 = value2;
                value2 = test;
            }
           
            Random rnd = new Random();
            int value3 = rnd.Next(value1 , value2 + 1);
            return View(viewName: "Index", model: (value3));
        }
    }
}