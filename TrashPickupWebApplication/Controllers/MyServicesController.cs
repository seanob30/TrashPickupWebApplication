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
        private ApplicationDbContext _context;
        public MyServicesController()
        {
            _context = new ApplicationDbContext();
        }
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
        public ActionResult ChangeMyInfo(UserInfo model)
        {
            _context.UserInfo.Add(model);
            _context.SaveChanges();
            return RedirectToAction("MyServices", "Home");
        }
        public ActionResult ViewMyBill()
        {
            return View();
        }
    }
}