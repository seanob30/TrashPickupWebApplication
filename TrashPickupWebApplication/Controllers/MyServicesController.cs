using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrashPickupWebApplication.Controllers
{
    public class MyServicesController : Controller
    {
        // GET: MyServices
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChangeMyServices()
        {
            return View();
        }
        public ActionResult ChangeMyInfo()
        {
            return View();
        }
        public ActionResult ViewMyBill()
        {
            return View();
        }
    }
}