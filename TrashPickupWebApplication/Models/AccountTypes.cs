using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class AccountTypes
    {
        [Key]
        public int ID { get; set; }
        public string AccountType { get; set; }
    }
}