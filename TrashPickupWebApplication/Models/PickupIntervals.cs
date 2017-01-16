using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class PickupIntervals
    {
        [Key]
        public int ID { get; set; }
        public int Once { get; set; }
        public int EveryDay { get; set; }
        public int OnceAWeek { get; set; }
        public int EveryOtherWeek { get; set; }
        public int OnceAMonth { get; set; }

    }
}