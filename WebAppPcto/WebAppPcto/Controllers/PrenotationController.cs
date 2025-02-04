using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppPcto.Data;

namespace WebAppPcto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrenotationController : ControllerBase
    {

        private readonly AgenziaDbContext _context;
        public PrenotationController(AgenziaDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var result = _context.Prenotation;
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var pren = await _context.Prenotation.FindAsync(id);
            if (pren == null)
            {
                return NotFound("viaggi non trovati");
            }
            _context.Prenotation.Remove(pren);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPost]
        public ActionResult Post(Prenotazione p)
        {
            _context.Prenotation.Add(p);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }   
}

