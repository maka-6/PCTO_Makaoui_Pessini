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

        [HttpPost]
        public ActionResult Post(viaggio v)
        {
            _context.Viagg.Add(v);
            _context.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
