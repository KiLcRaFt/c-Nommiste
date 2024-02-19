using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VMC2_0.Models
{
    public class GuestContext
    {
        public DbSet<Guest> Guests { get; set; }
    }
}