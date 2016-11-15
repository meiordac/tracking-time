using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrackingTime.Models
{
    public class Project
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }
        public int CustomerId { get; set; }
        public string Title { get; set; }
        public DateTime Deadline { get; set; }
        public Status Status { get; set; }

        public virtual Customer Customer { get; set; }
    }

    public enum Status
    {
        Proposed = 1,
        Active = 2,
        Completed = 3,
        Canceled = 4
    }
}