using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrackingTime.Models
{
    public class TimeActivity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TimeActivityId { get; set; }
        public int ProjectId { get; set; }
        public string Username { get; set; }
        public WorkType WorkType { get; set; }
        public string Description { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }

        public virtual Project Project { get; set; }

    }

    public enum WorkType
    {
        Development = 1,
        Testing = 2,
        Management = 3,
        Design = 4,
        Bugs = 5
    }
}