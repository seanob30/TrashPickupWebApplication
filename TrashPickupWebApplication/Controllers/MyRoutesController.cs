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
            var zipcodes = _context.ZipCode.ToList();

            var viewModel = new MyRoutesViewModel()
            {
                ZipCodeList = zipcodes,
            };
            return View(viewModel);
        }
    }
}