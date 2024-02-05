using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VMC.Models
{
    public class GuestContext: DbContext
    {
        public DbSet<guest> Guests { get; set; }
    }
}