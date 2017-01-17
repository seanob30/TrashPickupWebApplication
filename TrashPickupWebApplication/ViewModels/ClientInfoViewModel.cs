using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrashPickupWebApplication.Models;

namespace TrashPickupWebApplication.ViewModels
{
    public class ClientInfoViewModel
    {
        public UserInfo User { get; set; }
        public Address Address { get; set; }
        public IEnumerable<City>City { get; set; }
        public IEnumerable<State>State { get; set; }
        public IEnumerable<ZipCode>ZipCode { get; set; }
        public IEnumerable<AccountTypes>AccountType { get; set; }

    }
}