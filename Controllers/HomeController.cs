using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCModels.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ashwani()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string str)
        {
            ViewBag.Hello = "Hello I am "  + Request.Form["name"] + " located at " + Request.Form["location"];
            return View();
        }
        public ActionResult TextBoxHelper()
        {
            return View();
        }
        [HttpPost]
        public ActionResult TextBoxHelper(string str)
        {
            ViewBag.Hello = "Hello " + Request.Form["name"];
            return View();
        }
    }
}