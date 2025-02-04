using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAppPcto.Controllers
{
    public class ViaggioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public class Viaggio
        {
            [Key]
            public int id { get; set; }
        }
    }
}
