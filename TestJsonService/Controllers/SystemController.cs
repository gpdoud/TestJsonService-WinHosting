using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestJsonService.Models;

namespace TestJsonService.Controllers {
    [Route("[controller]")]
    [ApiController]
    public class SystemController : ControllerBase {

        private AppDbContext _context = null;

        public SystemController(AppDbContext context) { _context = context; }

        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Models.System>>> GetAll() {
            return await _context.Systems.ToListAsync();
        }
        [HttpPost("{key}")]
        public async Task<IActionResult> AddUpdate(Models.System system, string key) {
            if(!system.Key.ToLower().Equals(key.ToLower())) { return new ConflictResult(); }
            var sys = await _context.Systems.SingleOrDefaultAsync(x => x.Key == system.Key);
            if(sys != null) {
                sys.Value = system.Value;
            } else {
                await _context.Systems.AddAsync(system);
            }
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpGet("status")]
        public IActionResult GetStatus() {
            var result = new {
                Status = "OK"
            };
            return new JsonResult(result);
        }
    }
}