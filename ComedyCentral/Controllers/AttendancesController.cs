using System.Linq;
using System.Web.Http;
using ComedyCentral.Dtos;
using ComedyCentral.Models;


namespace ComedyCentral.Controllers.Api
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        //    public IHttpActionResult Attend([FromBody] int comedyId)
        public IHttpActionResult Attend(AttendanceDto dto)
        {
            var userId = "4651c51c-f935-48a0-8d79-f030fc14607a";
                //HttpContext.Current.User.Identity.GetUserId();


            if (_context.Attendances.Any(a => a.AttendeeId == userId && a.ComedyId == dto.ComedyId))
                return BadRequest("The attendance already exists.");

            var attendance = new Attendance
            {
                ComedyId = dto.ComedyId,
                AttendeeId = userId
            };
            _context.Attendances.Add(attendance);
            _context.SaveChanges();

            return Ok();
        }
    }
}
