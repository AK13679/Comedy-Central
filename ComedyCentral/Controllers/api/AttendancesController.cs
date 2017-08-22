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
            var userId = "91f900fb-b7b1-4301-bd4f-c6c3b8c54e6d";
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
