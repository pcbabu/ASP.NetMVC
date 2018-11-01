using surveyIntroPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace surveyIntroPS.Controllers
{
    public class HomeController : Controller
    {
        private Survey db = new Survey();
        public ActionResult Index()
        {
            bool login = false;
            if (!login) { return View("Login"); }
            else{ return View(); }

            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page.";

            return View();
        }
        public ActionResult Login()
        {
            ViewBag.Message = "Login page.";

            return View();
        }
    }
}