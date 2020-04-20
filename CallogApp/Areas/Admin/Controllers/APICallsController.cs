using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CallogApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CallogApp.Areas.Admin.Controllers
{
    [Route("api/call")]
    [ApiController]
    public class APICallsController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public APICallsController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET CALLS API
        public async Task<IActionResult> GetMessage()
        {

            var calls = await _db.Calls.ToListAsync();

           

            return Ok( new { data = calls } );
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var call = await _db.Calls.FirstOrDefaultAsync(U => U.Id == id);
            if (call == null)
            {
                return Ok(new { success = true, message = "Error while Deleting" });
            }
            _db.Calls.Remove(call);
            await _db.SaveChangesAsync();
            return Ok(new { success = true, message = "Delete successful" });
        }
    }
}