using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public StreetAddress StreetAddress { get; set; }
        public string StreetAddressID { get; set; }
        public City City { get; set; }
        public string CityID { get; set; }
        public State State { get; set; }
        public string StateID { get; set; }
        public ZipCode ZipCode { get; set; }
        public int ZipCodeID { get; set; }


    }
}