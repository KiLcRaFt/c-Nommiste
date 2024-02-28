using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace Koolitused.Models
{
    public class KoolitusDbInitializer: DropCreateDatabaseAlways<KoolitusContext>
    {
        protected override void Seed(KoolitusContext db)
        {
            db.Koolituss.Add(
                new Koolitus
                {
                    Koolitusenimetus = "Eesti keel",
                    Koolitusekirjeldus = "Õpime eesti keelt",
                    Koolitusemaht = 12,
                    Koolitusehind = 100,
                    OpetajaId = 1
                });
            db.Lapss.Add(
                new Laps
                {
                    LapseEesnimi = "Mark",
                    LapsePerenimi = "Tsukerberg",
                    Sunniaasta = 18
                });
            base.Seed(db);
        }
    }
}