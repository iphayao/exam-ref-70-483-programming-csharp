using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Chapter2.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// LISTING 2-30 The dynamic keyword in ASP.NET MVC
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.MyDynamicValue = "This peroperty is not statically type";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}