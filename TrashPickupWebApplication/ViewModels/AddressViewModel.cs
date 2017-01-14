using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TrashPickupWebApplication.Models;

namespace TrashPickupWebApplication.ViewModels
{
    public class AddressViewModel
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public StreetAddress StreetAddress { get; set; }
        public int StreetAddressID { get; set; }
        [Required]
        public City City { get; set; }
        public int CityID { get; set; }
        [Required]
        public State State { get; set; }
        public int StateID { get; set; }
        [Required]
        public ZipCode ZipCode { get; set; }
        public int ZipCodeID { get; set; }
    }
}