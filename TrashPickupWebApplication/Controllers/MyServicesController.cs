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

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
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
                AccountTypesList = accountTypes,
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
        public ActionResult ViewMyServices()
        {
            var scheduledServices = _context.ScheduledServices.ToList();

            var viewModel = new ServicesViewModel
            {
                ScheduledServicesList = scheduledServices
            };

            return View(viewModel);
        }
        public ActionResult AddService()
        {
            var days = _context.Days.ToList();
            var intervals = _context.PickupIntervals.ToList();
            var regularServices = _context.RegularServices.ToList();

            var viewModel = new ServicesViewModel
            {
                PickupIntervalsList =  intervals,
                DaysList = days,
                RegularServicesList = regularServices
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddService(ServicesViewModel model)
        {
            var currentUserName = User.Identity.Name;
            var service = new ScheduledServices
            {
                ScheduledUser = currentUserName,
                RegularServiceID = model.RegularServiceId,
                PickupIntervalID = model.PickupIntervalId,
                DayID = model.DayId
            };
            _context.ScheduledServices.Add(service);
            _context.SaveChanges();
            return RedirectToAction("ViewMyServices", "MyServices");
        }

        public ActionResult ChangeMyPaymentInfo()
        {
            var cardTypes = _context.CardType.ToList();
            
            var viewModel = new PaymentInfoViewModel
            {
                CardTypesList = cardTypes
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ChangeMyPaymentInfo(PaymentInfoViewModel model)
        {
            try
            {
                var currentUserName = User.Identity.Name;
                var paymentMethodInDatabase = _context.PaymentInformation.SingleOrDefault(m => m.CustomerName == currentUserName);

                paymentMethodInDatabase.CardTypeId = model.PaymentInformation.CardTypeId;
                paymentMethodInDatabase.CardNumber = model.CardNumber;
                paymentMethodInDatabase.ExpirationMonth = model.ExpirationMonth;
                paymentMethodInDatabase.ExpirationYear = model.ExpirationYear;
                paymentMethodInDatabase.CCVCode = model.CCVCode;
                paymentMethodInDatabase.NameOnCard = model.NameOnCard;
                paymentMethodInDatabase.ZipcodeOnCard = model.ZipCode;
                paymentMethodInDatabase.CustomerName = currentUserName;

                _context.SaveChanges();
                return RedirectToAction("Index", "MyServices");
            }
            catch
            {
                var currentUserName = User.Identity.Name;
                var newPaymentMethod = new PaymentInformation
                {
                    CardTypeId = model.PaymentInformation.CardTypeId,
                    CardNumber = model.CardNumber,
                    ExpirationMonth = model.ExpirationMonth,
                    ExpirationYear = model.ExpirationYear,
                    CCVCode = model.CCVCode,
                    NameOnCard = model.NameOnCard,
                    ZipcodeOnCard = model.ZipCode,
                    CustomerName = currentUserName
                };
                _context.PaymentInformation.Add(newPaymentMethod);
                _context.SaveChanges();
                return RedirectToAction("Index", "MyServices");
            }
        }

        
    }
}
