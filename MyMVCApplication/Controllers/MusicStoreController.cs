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
        public ActionResult Music()
        {
            return View();
        }
    }
}