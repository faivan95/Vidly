﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek" },
                new Movie { Name = "Madagascar" },
                new Movie { Name = "The Lion King" }
            };

            return View(movies);
        }

        /*
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (pageIndex==null)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month}:regex(\\d{4}:range(1,12))")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }*/
    }
}