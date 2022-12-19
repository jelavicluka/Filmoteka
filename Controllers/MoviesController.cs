using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filmoteka.Models;
using Filmoteka.ViewModels;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace Filmoteka.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController() { _context = new ApplicationDbContext(); }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        [Authorize(Roles = RoleName.CanManageMovies)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movies movies)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movies = movies,
                    Genre = _context.Genres.ToList()
                };

                return View("MovieForm", viewModel);
            }

            if (movies.Id == 0)
            {
                movies.DateAdded = DateTime.Now;
                movies.NumberInStock = Movies.Empty;

                _context.Movies.Add(movies);
            }
            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == movies.Id);

                movieInDb.Name = movies.Name;
                movieInDb.ReleaseDate = movies.ReleaseDate;
                movieInDb.GenreId = movies.GenreId;
                movieInDb.NumberInStock = movies.NumberInStock;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (id == 0)
                New();

            var viewModel = new MovieFormViewModel
            {
                Movies = movie,
                Genre = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        [Authorize(Roles =RoleName.CanManageMovies)]
        public ActionResult New()
        {
            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel()
            {
                Movies = new Movies(),
                Genre = genres
            };

            return View("MovieForm", viewModel);
        }

        // GET: Movies
        public ActionResult Index()
        {
            //var movies = _context.Movies.Include(m => m.Genre).ToList();

            //return View(movies);

            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");
            else
                return View("ReadOnlyList");
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(c => c.Id == id);

            return View(movie);
        }
    }
}