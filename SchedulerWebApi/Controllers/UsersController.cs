using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SchedulerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var test = _context.Users.ToList();
            return Ok("Success");
        }
    }
}
