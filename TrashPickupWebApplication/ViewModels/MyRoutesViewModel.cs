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
        public string ZipCodeId { get; set; }


        public IEnumerable <ZipCode> ZipCodeList { get; set; }
        public IEnumerable<ApplicationUser> ApplicationUserList { get; set; }
    }
}