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

        public string ServiceTypeID { get; set; }
        public RegularServices ServiceTypeId { get; set; }

        public string ServiceIntervalID { get; set; }
        public PickupIntervals ServiceIntervalId { get; set; }
    }
}