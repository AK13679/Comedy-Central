using System.Linq;
using System.Web;
using System.Web.Http;
using ComedyCentral.Models;
using Microsoft.AspNet.Identity;


namespace ComedyCentral.Controllers.Api
{
    //[Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend([FromBody] int comedyId)
        {
            var userId = HttpContext.Current.User.Identity.GetUserId();

            User.Identity.GetUserName();

            if (_context.Attendances.Any(a => a.AttendeeId == userId && a.ComedyId == comedyId))
                return BadRequest("The attendance already exists.");

            var attendance = new Attendance
            {
                ComedyId = comedyId,
                AttendeeId = userId
            };
            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}
