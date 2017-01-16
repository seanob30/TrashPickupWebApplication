using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class RegularServices
    {
        [Key]
        public int ID { get; set; }
        public string ServiceName { get; set; }
        public int CostPerPickup { get; set; }

    }
}