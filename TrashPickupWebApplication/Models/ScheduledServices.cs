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
        public string SeceduledUser { get; set; }
        public RegularServices ServiceTypeId { get; set; }
        public int ServiceTypeID { get; set; }
        public PickupIntervals ServiceIntervalId { get; set; }
        public int ServiceIntervalID { get; set; }
        public Days Days { get; set; }
        public int DayId { get; set; }
    }
}