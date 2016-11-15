using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackingTime.Models
{
    public class Report
    {
        public DateTime StarDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public List<TimeActivity> Activities { get; set; }
    }
}