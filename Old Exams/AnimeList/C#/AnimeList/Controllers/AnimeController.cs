﻿using System.Linq;
using System.Web.Mvc;
using AnimeList.Models;

namespace AnimeList.Controllers
{
    [ValidateInput(false)]
    public class AnimeController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new AnimeListDbContext())
            {
                var animes = db.Animes.ToList();
                return View(animes);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View(new Anime());
        }

        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Anime anime)
        {
            using (var db = new AnimeListDbContext())
            {
                if (this.ModelState.IsValid)
                {
                    db.Animes.Add(anime);
                    db.SaveChanges();
                    return Redirect("/");
                }
                return View(anime);
            }
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            using (var db = new AnimeListDbContext())
            {
                var anime = db.Animes.Find(id);
                if (anime == null)
                {
                    return Redirect("/");
                }
                return View(anime);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int? id, Anime animeModel)
        {
            using (var db = new AnimeListDbContext())
            {
                var anime = db.Animes.Find(id);
                db.Animes.Remove(anime);
                db.SaveChanges();
                return Redirect("/");
            }
        }
    }
}