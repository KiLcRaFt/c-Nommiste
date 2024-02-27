using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC3_0.Models
{
    public class GuestContext: DbContext
    {
        public DbSet<Guest> Guests { get; set; }
    }
}