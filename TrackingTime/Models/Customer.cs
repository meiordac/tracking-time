using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackingTime.Models
{
    public class Customer
    {
        public string Name { get; }
        public string Contact { get; }
        public string Phone { get; }
        public string Status { get; }

        public Customer(string name, string contact, string phone, string status)
        {
            Name = name;
            Contact = contact;
            this.Phone = phone;
            this.Status = status;
        }
    }
}