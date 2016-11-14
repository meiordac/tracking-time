using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackingTime.Models
{
    public class TimeActivity
    {
        public int TimeActivityId { get; set; }
        public int ProjectId { get; set; }
        public string Username { get; set; }
        public string WorkType { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }

    }
}