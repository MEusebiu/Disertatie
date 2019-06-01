using DataContext.Entities;
using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniLibrary.Controllers
{
    public class GenresController : Controller
    {
        private IGenreService genreService;

        public GenresController(IGenreService genreService)
        {
            this.genreService = genreService;
        }

        // GET: Genres
        public ActionResult Index()
        {
            var genres = genreService.GetAllGenres();
            return View(genres);
        }

        public ActionResult Create()
        {
            var genre = new Genre();
            return View(genre);
        }

        [HttpPost]
        public ActionResult Create(Genre genre)
        {
            if (ModelState.IsValid)
            {
                genreService.AddGenre(genre);
                return RedirectToAction("Index");
            }
            else
            {
                return View(genre);
            }
        }

        public ActionResult Edit(int genreId)
        {
            var genre = genreService.GetGenreById(genreId);
            return View(genre);
        }

        [HttpPost]
        public ActionResult Edit(Genre genre)
        {
            if (ModelState.IsValid)
            {
                genreService.UpdateGenre(genre);
                return RedirectToAction("Index");
            }
            else
            {
                return View(genre);
            }
        }

    }
}