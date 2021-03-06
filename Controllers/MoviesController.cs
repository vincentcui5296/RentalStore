﻿using MovieRentalStore.Models;
using MovieRentalStore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRentalStore.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie> {
                new Movie() { Id = 1, Name = "Shrek" },
                new Movie() { Id = 2, Name = "Wall-e"}
            };
        }

        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Id = 0,
                Name = "Shrek!"
            };

            var customers = new List<Customer>
            {
                new Customer() { Name = "Customer 1"},
                new Customer() { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }
    }
}