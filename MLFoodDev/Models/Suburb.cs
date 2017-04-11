using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MLFoodDev.Models
{
    public class Suburb : Restaurant
    {
        public string BurbName { get; set; }
        public int PostCode { get; set; }
    }
}