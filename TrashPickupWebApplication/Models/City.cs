﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class City
    {
        [Key]
        public int ID { get; set; }
        public string Cities { get; set; }
    }
}