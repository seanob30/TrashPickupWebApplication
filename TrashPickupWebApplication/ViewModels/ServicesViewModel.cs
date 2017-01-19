using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TrashPickupWebApplication.Models;

namespace TrashPickupWebApplication.Models
{
    public class ServicesViewModel
    {
        [Required]
        [Display(Name = "Regular Service")]
        public int RegularServiceId { get; set; }

        [Required]
        [Display(Name = "Pickup Interval")]
        public int PickupIntervalId { get; set; }

        [Required]
        [Display(Name = "Day of Pickup")]
        public int DayId { get; set; }

        public IEnumerable<PickupIntervals> PickupIntervalsList { get; set; }
        public IEnumerable<Days> DaysList { get; set; }
        public IEnumerable<RegularServices> RegularServicesList { get; set; }
        public IEnumerable<ScheduledServices> ScheduledServicesList { get; set; }

        public ScheduledServices ScheduledServices { get; set; }

        public ApplicationDbContext _context = new ApplicationDbContext();

    }
}