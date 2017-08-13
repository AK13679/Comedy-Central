using System.Linq;
using System.Web.Mvc;
using ComedyCentral.Models;
using ComedyCentral.ViewModels;

namespace ComedyCentral.Controllers
{
    public class ComediesController : Controller
    {

        private readonly ApplicationDbContext _context;

        public ComediesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Comedies
        public ActionResult Create()
        {
            var viewModel = new ComedyViewModel
            {
                Descriptions = _context.Descriptions.ToList()
            };

            return View(viewModel);
        }
    }
}