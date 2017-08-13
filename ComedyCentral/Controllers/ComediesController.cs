using System.Linq;
using System.Web.Mvc;
using ComedyCentral.Models;
using ComedyCentral.ViewModels;
using Microsoft.AspNet.Identity;


namespace ComedyCentral.Controllers
{
    public class ComediesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ComediesController()
        {
            _context = new ApplicationDbContext();
        }

       [Authorize]
        public ActionResult Create()
        {
            var viewModel = new ComedyViewModel
            {
                Descriptions = _context.Descriptions.ToList()
            };

            return View(viewModel);
        }


        [Authorize]
        [HttpPost]
        public ActionResult Create(ComedyViewModel viewModel)
        {
            // var description = _context.Descriptions.Single(g => g.Id == viewModel.Description);
            // var artist = _context.Users.Single(u => u.Id == User.Identity.GetUserId());
            if (!ModelState.IsValid)
            {
                viewModel.Descriptions = _context.Descriptions.ToList();
                return View("Create", viewModel);
            }

            var comedy = new Comedy
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                DescriptionId = viewModel.Description,
                Venue = viewModel.Venue
            };

            _context.Comedies.Add(comedy);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}