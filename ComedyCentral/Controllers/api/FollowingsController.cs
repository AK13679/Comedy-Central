using System.Linq;
using System.Web.Http;
using ComedyCentral.Dtos;
using ComedyCentral.Models;

namespace GigHub.Controllers
{
    //[Authorize]
    public class FollowingsController : ApiController
    {
        private ApplicationDbContext _context;

        public FollowingsController()
        {
            _context = new ApplicationDbContext();    
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto dto)
        {
            // var userId = User.Identity.GetUserId();
            var userId = "91f900fb-b7b1-4301-bd4f-c6c3b8c54e6d";

            if (_context.Followings.Any(f => f.FolloweeId == userId && f.FolloweeId == dto.FolloweeId))
                return BadRequest("Following already exists.");

            var following = new Following
            {
                FollowerId = userId,
                FolloweeId = dto.FolloweeId
            };
            _context.Followings.Add(following);
            _context.SaveChanges();

            return Ok();
        }
    }
}
