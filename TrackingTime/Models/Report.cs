using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackingTime.Models
{
    public class Report
    {
        public int ReportId { get; set; }
        public DateTime StarDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

    }
}