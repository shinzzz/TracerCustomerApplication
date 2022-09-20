using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TracerCustomerApplication.Models
{
    public class CustomerDBContext: DbContext
    {
        public CustomerDBContext() :base("dbconnection")
        { 

        }
        public DbSet<Customer> Customers { get; set;}
    }
}