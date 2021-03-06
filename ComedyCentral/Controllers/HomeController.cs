﻿using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using ComedyCentral.Models;
using ComedyCentral.ViewModels;

namespace ComedyCentral.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var upcomingShows = _context.Comedies
                .Include(c => c.Artist)
                .Include(c=>c.Description)
                .Where(c => c.DateTime > DateTime.Now);


            var viewModel = new HomeViewModel
            {
                UpcomingShows = upcomingShows,
                ShowActions = User.Identity.IsAuthenticated,
              
            };


            return View(viewModel);
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}