using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackingTime.Models
{
    public class TimeActivity
    {
        public string Project { get; }
        public string Username { get; }
        public string WorkType { get; }
        public string Description { get; }
        public DateTime StartDateTime { get; }
        public DateTime FinishDateTime { get; }

        public TimeActivity(string project, string username, string workType, string description, DateTime startDateTime, DateTime finishDateTime)
        {
            Project = project;
            Username = username;
            this.WorkType = workType;
            Description = description;
            StartDateTime = startDateTime;
            this.FinishDateTime = finishDateTime;
        }
    }
}