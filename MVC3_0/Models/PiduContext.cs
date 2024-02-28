using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC3_0.Models
{
    public class PiduContext:DbContext
    {
        public DbSet<Pidu> Pidus { get; set; }
    }
}