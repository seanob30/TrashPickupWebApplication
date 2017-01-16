using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class Days
    {
        [Key]
        public int ID { get; set; }
        public string Day { get; set; }
    }
}