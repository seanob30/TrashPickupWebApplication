using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace TrashPickupWebApplication.Models
{
    public class ZipCode
    {
        [Key]
        public int ID { get; set; }
        public int Zipcodes { get; set; }
    }
}