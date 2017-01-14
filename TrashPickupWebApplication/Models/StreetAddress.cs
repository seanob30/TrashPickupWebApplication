using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class StreetAddress
    {
        [Key]
        public int ID { get; set; }
        public string Addresses { get; set; }
    }
}