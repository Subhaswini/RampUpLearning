using Microsoft.AspNetCore.Mvc;
using SampleEmplyMVC.Models;
using System;
using System.Collections.Generic;

namespace SampleEmplyMVC.Controllers
{
    public class UserController: Controller
    {
        public IActionResult Index()
        {
            //User user = new User()
            //{
            //    FirstName = "CJ",
            //    LastName = "Subhaswini",
            //    Birthday = new DateTime(1998, 3, 25)
            //};
            List<User> user = new List<User>()
            {
                new User() { LastName= "Subhaswini", FirstName = "CJ", Birthday = new DateTime(1998,03,25) },
                new User() { LastName="Sharmila", FirstName ="A", Birthday = new DateTime(1998,05,22) },
                new User() { LastName="Sneha", FirstName = " Prasanna", Birthday = new DateTime(1998,07,21) }
            };
            return View(user);
        }
    }
}
