using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickupWebApplication.Models;

namespace TrashPickupWebApplication.Controllers
{
    public class MyRoutesController : Controller
    {
        public ApplicationDbContext _context;
        public MyRoutesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: MyRoutes
        public ActionResult Index()
        {
            List<ApplicationUser> inTerritories = new List<ApplicationUser>();
            var zipcodes = _context.ZipCode.ToList();
            var viewModel = new MyRoutesViewModel()
            {
                ZipCodeList = zipcodes,
                usersInTerritory = inTerritories,
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(MyRoutesViewModel model)
        {
            List<ApplicationUser> users = new List<ApplicationUser>();
            List<ApplicationUser> applicationUsers = _context.Users.ToList();
            var selectedZipcode = model.ZipCodeId;
            var zipcodes = _context.ZipCode.ToList();
            foreach (ApplicationUser i in applicationUsers)
            {
                if (i.ZipCodeId == selectedZipcode)
                {
                    users.Add(i);
                }
            }
            var viewModel = new MyRoutesViewModel()
            {
                usersInTerritory = users,
                ZipCodeList = zipcodes
            };
            return View(viewModel);
        }
    }
            
}