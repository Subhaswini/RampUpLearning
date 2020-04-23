using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class MusicStoreController : Controller
    {
        // GET: MusicStore
        //[ActionName("Store")] 

        /*public ActionResult Index()
        {
            return View();
        }*/

        [OutputCache(Duration = 60)]
        //[Authorize]
        public ActionResult Music()
        {
            return View();
        }
        public string Welcome()
        {
            return "Hello, this is welcome action message";
        }
    }
}