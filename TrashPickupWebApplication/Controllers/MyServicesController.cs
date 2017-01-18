﻿using System;
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
        public ActionResult ChangeMyInfo()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeMyInfo(RegisterViewModel model)
        {
            return View();
        }
        public ActionResult ChangeMyServices()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeMyServices(ServicesViewModel model)
        {
            //maybe sent to change my paym,ent if thwey dont have it set up yet
            return RedirectToAction("Index", "MyServices");
        }
        public ActionResult ChangeMyPaymentInfo()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeMyPaymentInfo(PaymentViewModel model)
        {
            return RedirectToAction("Index", "MyServices");
        }
    }
}
