using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class  AccountTypes : IEnumerable
    {
        public int ID { get; set; }
        public string AccountType { get; set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}