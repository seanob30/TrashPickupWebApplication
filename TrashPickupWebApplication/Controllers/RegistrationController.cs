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
        public ActionResult ChangeMyInfo(UserInfo model)
        {
            ViewBag.AccountTypes = _context.AccountType.ToList();
            if (model.ID == 0)
            {
                _context.UserInfo.Add(model);
            }
            else
            {
                var customerInDb = _context.UserInfo.Single(c => c.ID == model.ID);

                TryUpdateModel(customerInDb);
            }
            _context.SaveChanges();
            return RedirectToAction("MyServices", "Home");
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