﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VMC.Models
{
    public class GuestContext : DbContext
    {
        public DbSet<guest> Guests { get; set; }
    }
}