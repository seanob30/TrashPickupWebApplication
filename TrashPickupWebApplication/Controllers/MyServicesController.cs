using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
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
        public ActionResult ChangeMyInfo()
        {
            var currentUserName = User.Identity.Name;
            var usersInDatabase = _context.Users.ToList();
            var accountTypes = _context.AccountType.ToList();
            var cities = _context.City.ToList();
            var states = _context.State.ToList();
            var zipcodes = _context.ZipCode.ToList();
            var currentUser = _context.Users.FirstOrDefault(m => m.UserName == currentUserName);

            var viewModel = new ChangeInfoViewModel()
            {
                FirstName = currentUser.FirstName,
                LastName = currentUser.LastName,
                StreetAddress = currentUser.StreetAddress,
                CitiesList = cities,
                StatesList = states,
                ZipCodesList = zipcodes,
                AccountTypesList = accountTypes
            };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeMyInfo(ChangeInfoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return HttpNotFound();
            }
            else
            {
                var currentUserName = User.Identity.Name;
                var userInDatabase = _context.Users.SingleOrDefault(m => m.UserName == currentUserName);

                userInDatabase.FirstName = model.FirstName;
                userInDatabase.LastName = model.LastName;
                userInDatabase.AccountTypeId = model.ApplicationUser.AccountTypeId;
                userInDatabase.StreetAddress = model.StreetAddress;
                userInDatabase.CityId = model.ApplicationUser.CityId;
                userInDatabase.StateId = model.ApplicationUser.StateId;
                userInDatabase.ZipCodeId = model.ApplicationUser.ZipCodeId;
            }
            
            _context.SaveChanges();
            return RedirectToAction("Index", "MyServices");
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
