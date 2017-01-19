using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TrashPickupWebApplication.Models;

namespace TrashPickupWebApplication.Models
{
    public class PaymentInfoViewModel
    {
        private ApplicationDbContext _context;

        public PaymentInfoViewModel()
        {
            _context = new ApplicationDbContext();
        }

        [Required]
        [Display(Name = "Card Type")]
        public int CardTypeId { get; set; }

        [Required]
        [Display(Name = "Card Number")]
        public int CardNumber { get; set; }

        [Required]
        [Display(Name = "Expiration Month")]
        public int ExpirationMonth { get; set; }

        [Required]
        [Display(Name = "Expiration Year")]
        public int ExpirationYear { get; set; }

        [Required]
        [Display(Name = "City")]
        public int CCVCode { get; set; }

        [Required]
        [Display(Name = "Name On Card")]
        public string NameOnCard { get; set; }

        [Required]
        [Display(Name = "Zipcode")]
        public int ZipCode { get; set; }

        [Display(Name = "Customer Username")]
        public string CustomerUsername { get; set; }

        public IEnumerable<CardTypes> CardTypesList { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public PaymentInformation PaymentInformation { get; set; }

    }
}