﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashPickupWebApplication.Models
{
    public class CardTypes
    {
        [Key]
        public int ID { get; set; }
        public string CardName { get; set; }

    }
}