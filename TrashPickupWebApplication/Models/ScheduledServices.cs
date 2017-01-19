using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class ScheduledServices
    {
        [Key]
        public int ID { get; set; }
        public string ScheduledUser { get; set; }
        public RegularServices RegularService { get; set; }
        public int RegularServiceID { get; set; }
        public PickupIntervals PickupInterval { get; set; }
        public int PickupIntervalID { get; set; }
        public Days Days { get; set; }
        public int DayID { get; set; }
    }
}