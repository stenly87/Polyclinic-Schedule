using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Polyclinic_Schedule.DB;

namespace Polyclinic_Schedule.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserCabinetController : ControllerBase
    {
        readonly User30Context db;

        public UserCabinetController(User30Context db)
        {
            this.db = db;
        }

        [HttpGet]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            try
            {
                var user = await db.Users.
                    Include(s => s.Schedules).
                    FirstOrDefaultAsync(s => s.Id == id);
                if (user == null)
                    return NotFound();
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest($" {ex.Message}");
            }
        }
    }
}
