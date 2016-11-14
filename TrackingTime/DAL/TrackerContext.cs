using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TrackingTime.Models;

namespace TrackingTime.DAL
{
    public class TrackerContext : DbContext
    {

        public TrackerContext() : base("TrackerContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeActivity> TimeActivities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}