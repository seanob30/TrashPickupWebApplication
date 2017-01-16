using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickupWebApplication.Models;

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeMyInfo([Bind(Include = "FirstName,LastName")] UserInfo UserInfo )
        {
            if (ModelState.IsValid)
            {
                UserInfo.FirstName = "FirstName";
                UserInfo.LastName = "LastName";
            }
            return View("Index");
        }
        public ActionResult ViewMyBill()
        {
            return View();
        }
    }
}