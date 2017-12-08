using QuirkyBookRental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace QuirkyBookRental.Controllers
{
    public class GenreController : Controller
    {
        private readonly ApplicationDbContext _db;
        public GenreController()
        {
            _db = new ApplicationDbContext();
        }
        // GET: Genre
        public ActionResult Index()
        {
            return View(_db.Genres.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Genre genre)
        {
            if(ModelState.IsValid)
            {
                _db.Genres.Add(genre);
                _db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
           // var x = "";
            var genre = _db.Genres.Find(id);
            return View(genre);
        }

        [HttpPost]
        public ActionResult Edit(Genre genre)
        {
            if(ModelState.IsValid)
            {
                _db.Entry(genre).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            _db.Dispose();
        }
    }
}