using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public StreetAddress StreetAddress { get; set; }
        public int StreetAddressId { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
        public ZipCode Zipcode { get; set; }
        public int ZipCodeId { get; set; }
    }
}