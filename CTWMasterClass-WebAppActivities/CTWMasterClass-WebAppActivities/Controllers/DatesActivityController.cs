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
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult DateMagic(DateTime inputBirthday)
        {
            int leapYears = 0;
            int year = inputBirthday.Year;
            while(year<= DateTime.Now.Year)
            {
                if (DateTime.IsLeapYear(year))
                {
                    leapYears++;
                }
                year++;
            }
            return View(viewName: "Index", model: leapYears);
        }

    }
}