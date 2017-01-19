using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TrashPickupWebApplication.Models;

namespace TrashPickupWebApplication.Models
{
    public class MyRoutesViewModel
    {
        [Required]
        [Display(Name = "Zipcode")]
        public int ZipCodeId { get; set; }


        public IEnumerable <ZipCode> ZipCodeList { get; set; }
        public IEnumerable<ApplicationUser> ApplicationUserList { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<ApplicationUser> usersInTerritory { get; set; }
        public ApplicationDbContext ApplicationDbContext { get; set; }
        public ApplicationDbContext _context = new ApplicationDbContext();
    }
}