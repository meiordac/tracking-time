using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrackingTime.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }

    }
}