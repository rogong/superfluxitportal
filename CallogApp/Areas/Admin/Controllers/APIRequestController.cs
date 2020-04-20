using CallogApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace requestogApp.Areas.Admin.Controllers
{
    [Route("api/request")]
    [ApiController]
    public class APIRequestController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public APIRequestController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET requestS API
        public async Task<IActionResult> GetAllRequest()
        {

            var requests = await _db.Requests.ToListAsync();



            return Ok(new { data = requests });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var request = await _db.Requests.FirstOrDefaultAsync(U => U.Id == id);
            if (request == null)
            {
                return Ok(new { success = true, message = "Error while Deleting" });
            }
            _db.Requests.Remove(request);
            await _db.SaveChangesAsync();
            return Ok(new { success = true, message = "Delete successful" });
        }
    }
}
