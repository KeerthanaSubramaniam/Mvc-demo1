using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_demo1.Models
{
    public class DataContext:DbContext
    {
        public DbSet<User> users { get; set; }
    }
}