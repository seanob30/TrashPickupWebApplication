using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class UserInfo
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SignUpDate { get; set; }
        public AccountTypes AccountType { get; set; }
        public int AccountTypeId { get; set; }
        public Address Address { get; set; }
        public int AddressId { get; set; }
    }
}