using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickupWebApplication.Models;

namespace TrashPickupWebApplication.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _db;
        public HomeController()
        {
            _db = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Mission()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Message = "A list of our services.";

            return View(_db.Address.ToList());
        }
    }
}