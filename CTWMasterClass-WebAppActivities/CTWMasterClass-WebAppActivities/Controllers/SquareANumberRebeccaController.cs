using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class SquareANumberRebeccaController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult SaySquare(double inputNumber)
        {
            return View(viewName: "Index", model: (Math.Sqrt(inputNumber)));
        }

        public ActionResult Index2()
        {
            return View(viewName: "Index2", model: 0);
        }
        public ActionResult MagicNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                int temp = firstNumber;
                firstNumber = secondNumber;
                secondNumber = temp;
            }
            Random rand = new Random();
            int magicNumber;
            try{
                magicNumber = rand.Next(firstNumber, secondNumber + 1);
            }
            catch { magicNumber = -999; }
            
            return View(viewName: "Index2", model: magicNumber);
        }

    }
}