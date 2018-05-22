using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabNumber21GC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Register()
        {

            return View();
        }

        public ActionResult AddUser(string fname, string lname, string email, string phone, string pass)
        {
            string[] reg = { fname, lname, email, phone, pass };
            //List<string> result = new List<string>();
            //foreach (string i in reg)
            //{
            //    if (i == fname)
            //    {
            //        result.Add(i);
            //    }
            //}
            ViewBag.Message = fname;
            return View();
        }
    }
}