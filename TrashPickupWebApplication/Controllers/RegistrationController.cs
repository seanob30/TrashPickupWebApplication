using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickupWebApplication.Models;

namespace TrashPickupWebApplication.Controllers
{
    public class RegistrationController : Controller
    {
        ApplicationDbContext _context;
        public RegistrationController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContactInfo()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContactInfo(UserInfo model)
        {
            model.SignUpDate = DateTime.Now.ToString();
            _context.UserInfo.Add(model);
            _context.SaveChanges();
            return RedirectToAction("ServicesInfo", "Registration");
        }
        public ActionResult ServicesInfo()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ServicesInfo(UserInfo model)
        {

            return RedirectToAction("PaymentInfo", "Registration");
        }
    }
}