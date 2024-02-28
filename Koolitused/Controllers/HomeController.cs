using Koolitused.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Koolitused.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        KoolitusContext db = new KoolitusContext();
        [Authorize]
        public ActionResult Koolitused()
        {
            IEnumerable<Koolitus> koolituss = db.Koolituss;
            return View(koolituss);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Koolitus koolitus)
        {
            db.Koolituss.Add(koolitus);
            db.SaveChanges();
            return RedirectToAction("Koolituss");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Koolitus g = db.Koolituss.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            return View(g);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Koolitus g = db.Koolituss.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            db.Koolituss.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Koolituss");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            Koolitus g = db.Koolituss.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            return View(g);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditConfirmed(Koolitus koolitus)
        {
            db.Entry(koolitus).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Koolituss");
        }

        //Laps -----------------------------------------------

        [Authorize]
        public ActionResult Laps()
        {
            IEnumerable<Laps> laps = db.Lapss;
            return View(laps);
        }

        [HttpGet]
        public ActionResult laps_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult laps_Create(Laps laps)
        {
            db.Lapss.Add(laps);
            db.SaveChanges();
            return RedirectToAction("Laps");
        }

        [HttpGet]
        public ActionResult laps_Delete(int id)
        {
            Laps laps = db.Lapss.Find(id);
            if (laps == null)
            {
                return HttpNotFound();
            }
            return View(laps);
        }

        [HttpPost, ActionName("laps_Delete")]
        public ActionResult laps_DeleteConfirmed(int id)
        {
            Laps laps = db.Lapss.Find(id);
            if (laps == null)
            {
                return HttpNotFound();
            }
            db.Lapss.Remove(laps);
            db.SaveChanges();
            return RedirectToAction("Laps");
        }

        [HttpGet]
        public ActionResult laps_Edit(int? id)
        {
            Laps laps = db.Lapss.Find(id);
            if (laps == null)
            {
                return HttpNotFound();
            }
            return View(laps);
        }

        [HttpPost, ActionName("laps_Edit")]
        public ActionResult laps_EditConfirmed(Laps laps)
        {
            db.Entry(laps).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Laps");
        }

        //Õpetaja -------------------------------------------

        [Authorize]
        public ActionResult Opetaja()
        {
            IEnumerable<Opetaja> opetajas = db.Opetajas;
            return View(opetajas);
        }

        [HttpGet]
        public ActionResult opetaja_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult opetaja_Create(Opetaja opetajas)
        {
            db.Opetajas.Add(opetajas);
            db.SaveChanges();
            return RedirectToAction("Opetaja");
        }

        [HttpGet]
        public ActionResult opetaja_Delete(int id)
        {
            Opetaja opetajas = db.Opetajas.Find(id);
            if (opetajas == null)
            {
                return HttpNotFound();
            }
            return View(opetajas);
        }

        [HttpPost, ActionName("opetaja_Delete")]
        public ActionResult opetaja_DeleteConfirmed(int id)
        {
            Opetaja opetajas = db.Opetajas.Find(id);
            if (opetajas == null)
            {
                return HttpNotFound();
            }
            db.Opetajas.Remove(opetajas);
            db.SaveChanges();
            return RedirectToAction("Opetaja");
        }

        [HttpGet]
        public ActionResult opetaja_Edit(int? id)
        {
            Opetaja opetajas = db.Opetajas.Find(id);
            if (opetajas == null)
            {
                return HttpNotFound();
            }
            return View(opetajas);
        }

        [HttpPost, ActionName("opetaja_Edit")]
        public ActionResult opetaja_EditConfirmed(Opetaja opetajas)
        {
            db.Entry(opetajas).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Opetaja");
        }

        //Kursus ----------------------------------------------------

        [Authorize]
        public ActionResult Kursus()
        {
            IEnumerable<Kursus> kursus = db.Kursuss;
            return View(kursus);
        }

        [HttpGet]
        public ActionResult kursus_Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult kursus_Create(Kursus kursus)
        {
            db.Kursuss.Add(kursus);
            db.SaveChanges();
            return RedirectToAction("Kursus");
        }

        [HttpGet]
        public ActionResult kursus_Delete(int id)
        {
            Kursus kursus = db.Kursuss.Find(id);
            if (kursus == null)
            {
                return HttpNotFound();
            }
            return View(kursus);
        }

        [HttpPost, ActionName("kursus_Delete")]
        public ActionResult kursus_DeleteConfirmed(int id)
        {
            Kursus kursus = db.Kursuss.Find(id);
            if (kursus == null)
            {
                return HttpNotFound();
            }
            db.Kursuss.Remove(kursus);
            db.SaveChanges();
            return RedirectToAction("Kursus");
        }

        [HttpGet]
        public ActionResult kursus_Edit(int? id)
        {
            Kursus kursus = db.Kursuss.Find(id);
            if (kursus == null)
            {
                return HttpNotFound();
            }
            return View(kursus);
        }

        [HttpPost, ActionName("kursus_Edit")]
        public ActionResult kursus_EditConfirmed(Kursus kursus)
        {
            db.Entry(kursus).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Kursus");
        }
    }
}