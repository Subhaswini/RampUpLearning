using MyMVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        /*public string GetAllCustomers()
        {
            return @"<ul>
            <li>Ali Raza</li>
            <li>Mark Upston</li>
            <li>Allan Bommer</li>
            <li>Greg Jerry</li>
            </ul>";
        }*/
        public ActionResult Index()
        {
            var CustomerList = new List<Customer>{
                            new Customer() { CustomerId = 1, CustomerName = "John", Age = 18 } ,
                            new Customer() { CustomerId = 2, CustomerName = "Steve",  Age = 21 } ,
                            new Customer() { CustomerId = 3, CustomerName = "Bill",  Age = 25 } ,
                            new Customer() { CustomerId = 4, CustomerName = "Ram" , Age = 20 } ,
                            new Customer() { CustomerId = 5, CustomerName = "Ron" , Age = 31 } ,
                            new Customer() { CustomerId = 4, CustomerName = "Chris" , Age = 17 } ,
                            new Customer() { CustomerId = 4, CustomerName = "Rob" , Age = 19 }
                        };
            // Get the students from the database in the real application

            return View(CustomerList);
        }

      
       
    }
}