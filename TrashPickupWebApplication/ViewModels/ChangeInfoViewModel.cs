using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TrashPickupWebApplication.Models;

namespace TrashPickupWebApplication.Models
{
    public class ChangeInfoViewModel
    {
        private ApplicationDbContext _context;

        public ChangeInfoViewModel()
        {
            _context = new ApplicationDbContext();
        }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Account Type")]
        public int AccountTypeId { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Required]
        [Display(Name = "City")]
        public int CityId { get; set; }

        [Required]
        [Display(Name = "State")]
        public int StateId { get; set; }

        [Required]
        [Display(Name = "Zipcode")]
        public int ZipCodeId { get; set; }


        public IEnumerable<City> CitiesList { get; set; }
        public IEnumerable<State> StatesList { get; set; }
        public IEnumerable<ZipCode> ZipCodesList { get; set; }
        public IEnumerable<AccountTypes> AccountTypesList { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}