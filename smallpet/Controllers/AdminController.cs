using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using smallpet.Models;
using System.Data.Entity;

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
    }
}