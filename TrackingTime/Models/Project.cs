using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackingTime.Models
{
    public class Project
    {
        public Project(string title, string customer, DateTime deadline, string status)
        {
            Title = title;
            Customer = customer;
            Deadline = deadline;
            Status = status;
        }

        public string Title { get; }
        public string Customer { get; }
        public DateTime Deadline { get; }
        public string Status { get; }
    }
}