using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppPcto.Data;
using Microsoft.AspNetCore.Http;

namespace WebAppPcto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ViaggioController : Controller
    {
        private readonly AgenziaDbContext _context;
        public ViaggioController(AgenziaDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult Get()
        {
            var result = _context.Viagg;
            return Ok(result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id) 
        {
            var listviag = await _context.Viagg.FindAsync(id);
            if(listviag == null)
            {
                return NotFound("viaggi non trovati");
            }
            _context.Viagg.Remove(listviag);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        [HttpPost]
        public ActionResult Post(viaggio v)
        {
            _context.Viagg.Add(v);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
