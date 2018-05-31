using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LabNumber21GC.Models;

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

        public ActionResult AddNewCustomer(User u)
        {
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();

            ORM.Users.Add(u);
            ORM.SaveChanges();
            ViewBag.CustomerList = ORM.Users.ToList();
            return View("About");


        }

        public ActionResult ItemsList()
        {
            CoffeeShopDBEntities ORM = new CoffeeShopDBEntities();

            ViewBag.ItemsList = ORM.Items.ToList();

            return View();
        }

    }
}