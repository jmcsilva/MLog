﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLFoodDev.Models
{
    public class Order : Restaurant
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }

    }
}