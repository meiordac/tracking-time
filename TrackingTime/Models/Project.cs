using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackingTime.Models
{
    public class Project
    {

        public int ProjectId { get; set; }
        public int CustomerId { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public string Status { get; set; }
    }
}