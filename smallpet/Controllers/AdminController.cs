using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using smallpet.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace smallpet.Controllers
{
    public class AdminController : Controller
    {
        PetContext db = new PetContext();

        public ActionResult Index()
        {
            return View(db.Pets.ToList());
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Pet pet = db.Pets.Find(id);
            if (pet != null)
            {
                return View(pet);
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult Edit(Pet pet)
        {
            db.Entry(pet).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Pet pet)
        {
            db.Pets.Add(pet);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Pet b = db.Pets.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Pet b = db.Pets.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            db.Pets.Remove(b);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pet pet = await db.Pets.FindAsync(id);
            if (pet == null)
            {
                return HttpNotFound();
            }
            return View(pet);
        }
    }
}