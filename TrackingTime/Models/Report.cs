using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrackingTime.Models
{
    public class Report
    {
        [Key]
        public int ReportId { get; set; }
        public DateTime StarDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public List<TimeActivity> Activities { get; set; }
    }
}