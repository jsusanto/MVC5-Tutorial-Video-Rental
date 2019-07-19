using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            /*
             * Don't use the ViewData or ViewBag to pass data to the View
            ViewData["RandomMovie"] = movie;
            ViewBag.RandomMovie = movie;
            */

            return View(viewModel);
            //return Content("Hellow World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            return View(movie);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            //var movies = GetMovies();
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            //return Content(String.Format("PageIndex={0}&sortBy={1}", pageIndex, sortBy));
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie> {
                new Movie { Name = "Shrek" },
                new Movie { Name = "Wall-E" }
            };
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content("Year = " + year + " / Month = " + month);
        }
    }
}