using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class SquareANumberController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0.5);
        }
        [HttpPost]
        public ActionResult SaySquare(double inputNumber)
        {
            return View(viewName: "Index", model: (Math.Sqrt(inputNumber)));
        }
        public ActionResult MagicNumber()

        {
            return View(viewName: "MagicNumber", model: 0);
        }
        [HttpPost]
        public ActionResult SayMagicNumber(int inputNumber1, int inputNumber2)
        {
            int magicNum = 0;
            Random newrand = new Random();
            if (inputNumber1 == inputNumber2)
            {
                return View(viewName: "MagicNumber", model: (-999));

            }
            if (inputNumber1++ < inputNumber2)
            {
                magicNum = newrand.Next(inputNumber1++, inputNumber2);
                return View(viewName: "MagicNumber", model: (magicNum));
            }
            if (inputNumber2++ < inputNumber1)
            {
                magicNum = newrand.Next(inputNumber2++, inputNumber1);
                return View(viewName: "MagicNumber", model: (magicNum));
            }
            return View(viewName: "MagicNumber", model: (-999));
        }
    }
}