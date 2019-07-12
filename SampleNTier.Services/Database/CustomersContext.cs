using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SampleNTier.Services.Database
{
    public class CustomersContext : DbContext
    {
        public CustomersContext() : base("CustomersConnectionString")
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }
    }
}