using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class PaymentInformation
    {
        [Key]
        public int ID { get; set; }
        public CardTypes CardType { get; set; }
        public int CardTypeId { get; set; }
        public int CardNumber { get; set; }
        public int ExpirationMonth { get; set; }
        public int ExpirationYear { get; set; }
        public int CCVCode { get; set; }
        public string NameOnCard { get; set; }
        public int ZipcodeOnCard { get; set; }
    }
}