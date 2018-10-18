using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpressTesting.ViewModels;

namespace DevExpressTesting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var itemCount = EmployeeList.EmployeeListItems.Length;

            return View(EmployeeList.EmployeeListItems.Take(itemCount));
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