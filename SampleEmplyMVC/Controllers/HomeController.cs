using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleEmplyMVC.Models;

namespace SampleEmplyMVC.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            Movie movie = new Movie()
            {
                Title ="The Godfather",
                ReleaseDate = new DateTime(1972,3,24) 
            };
            return View(movie);
        }

        public IActionResult LayoutTest()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
    }
}
