using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCRDU.Models
{
    public class Datacontext:DbContext
    {
        public DbSet<Employees> employees { get; set; }

    }
}