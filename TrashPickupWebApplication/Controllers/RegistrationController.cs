using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickupWebApplication.Models;
using TrashPickupWebApplication.ViewModels;

namespace TrashPickupWebApplication.Controllers
{
    public class RegistrationController : Controller
    {
        ApplicationDbContext _context;
        AccountTypes _accountTypes;
        public RegistrationController()
        {
            _context = new ApplicationDbContext();
            _accountTypes = new AccountTypes();
        }
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContactInfo()
        {
            List<string> AccountTypes = new List<string>() { "Customer", "Employee", "Administrator" };
            ViewBag.AccountTypes = AccountTypes;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContactInfo(ClientInfoViewModel model)
        {
            if (model.User.ID == 0)
            {

            }
            else
            {
                var customerInDb = _context.UserInfo.Single(c => c.ID == model.User.ID);

                TryUpdateModel(customerInDb);
            }
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
        public ActionResult PaymentInfo()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PaymentInfo(UserInfo model)
        {
            return RedirectToAction("Index", "MyServices");
        }
    }
}