﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Koolitused.Models
{
    public class KoolitusContext: DbContext
    {
        public DbSet<Koolitus> Koolituss { get; set; }
        public DbSet<Laps> Lapss { get; set; }
        public DbSet<Opetaja> Opetajas { get; set; }
        public DbSet<Kursus> Kursuss { get; set; }
    }
}