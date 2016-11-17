using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TrackingTime.Migrations;
using TrackingTime.Models;

namespace TrackingTime.DAL
{
    public class TrackerContext : DbContext
    {

        public TrackerContext() : base("TrackerContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TrackerContext, Configuration>());
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TimeActivity> TimeActivities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<TrackingTime.Models.Report> Reports { get; set; }
    }
}