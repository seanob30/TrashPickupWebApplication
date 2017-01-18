using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class PaymentViewModel
    {
        [Required]
        [Display(Name = "Card Type")]
        public int CardTypeId { get; set; }

        [Required]
        [Display(Name = "Card Number")]
        public string CardNumber { get; set; }

        [Required]
        [Display(Name = "Expiration Month")]
        public int ExpirationMonth { get; set; }

        [Required]
        [Display(Name = "Expiration Year")]
        public int ExpirationYear { get; set; }

        [Required]
        [Display(Name = "CCV Code")]
        public int CCVCode { get; set; }

        [Required]
        [Display(Name = "Name on Card")]
        public string NameOnCard { get; set; }

        [Required]
        [Display(Name = "Zipcode on Card")]
        public int ZipcodeOnCard { get; set; }

        public IEnumerable<PaymentInformation> PaymentInformationList { get; set; }
        public IEnumerable<CardTypes> CardTypesList { get; set; }
    }
}