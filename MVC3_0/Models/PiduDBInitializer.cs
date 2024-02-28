using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC3_0.Models
{
    public class PiduDBInitializer: CreateDatabaseIfNotExists<PiduContext>
    {
        protected override void Seed(PiduContext context)
        {
            base.Seed(context);
        }
    }
}