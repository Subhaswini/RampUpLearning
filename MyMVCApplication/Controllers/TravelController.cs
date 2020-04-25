using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApplication.Models;
namespace MyMVCApplication.Controllers
{
    public class TravelController : Controller
    {
        // GET: Travel
        public ViewResult Index()
        {
            //ViewBag Example
            ViewBag.Countries = new List<string>()
            {
                "India",
                "UK",
                "US",
                "Canada"
            };

            //ViewData Example
            ViewData["Countries"] = new List<string>()
            {
                "India",
                "UK",
                "US",
                "Canada"
            };

            return View();
        }

        public ActionResult Details()
        {
            Travel Tourists = new Travel()
            {
                TouristId = 101,
                Name = "CJ Subhaswini",
                Gender = "Female",
                City = "Chennai"
            };
            return View(Tourists);
        }
    }
}