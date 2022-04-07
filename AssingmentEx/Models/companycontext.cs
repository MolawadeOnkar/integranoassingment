using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AssingmentEx.Models
{
    public class companycontext:DbContext
    {
        public companycontext() : base("name=scon")
        { }
        public DbSet<User>Users { get; set; }
        public DbSet<AdminUser>AdminUsers { get; set; }
    }
}