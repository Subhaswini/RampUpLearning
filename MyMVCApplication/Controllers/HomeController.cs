using MyMVCApplication.ActionFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    [MyLogActionFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        /* public ActionResult Index()
         {
             return RedirectToAction("GetAllCustomers", "Customer");
         }*/

        [ActionName("CurrentTime")]
        public string GetCurrentTime()
        {
            return TimeString();
        }

        [NonAction]
        public string TimeString()
        {
            return "Time is " + DateTime.Now.ToString("T");
        }

        public string GetDetails(string id, string name)
        {
            //return "Hii Cjay!";
            return "ID =" + id + "Name =" + name;
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