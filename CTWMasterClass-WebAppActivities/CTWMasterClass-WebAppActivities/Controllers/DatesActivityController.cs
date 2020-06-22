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
        //public ActionResult DateMagic(DateTime inputBirthday)
        //{
        //  int year = inputBirthday.Year;
        //  return View(viewName: "Index", model: year);
        // }
        //public ActionResult DateMagic(DateTime inputBirthday)
        //{
        //int age = DateTime.Now.Year - inputBirthday.Year;
        //int value = age / 4;
        //int compare = value * 4;
        // if (age == compare)
        // {
        //  age = age + 4;
        // }
        // return View(viewName: "Index", model: 4 - (age - compare));
        //}
        public ActionResult DateMagic(DateTime inputBirthday)
        {
            int age = DateTime.Now.Year - inputBirthday.Year;
            int test = age + inputBirthday.Year;
            int year = inputBirthday.Year;
            int test1 = test % 4;
            return View(viewName: "Index", model: age + test1);
        }
    }
}