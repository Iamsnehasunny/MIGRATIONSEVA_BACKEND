using Microsoft.AspNetCore.Mvc;
using MigrationSeva_Backend.Data;
using MigrationSeva_Backend.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MigrationSeva_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        public ContextClass Contact { get; set; }
        public ContactController(ContextClass contextclass)
        {
            this.Contact = contextclass;

        }
        [HttpPost("InsertQuery")]

        public async Task<ActionResult> InsertQuery(Contact cu)
        {

            Contact.tblcontact.Add(cu);
            await Contact.SaveChangesAsync();
            return Ok(cu);
        }

        [HttpGet("viewquery")]

        public async Task<List<Contact>> ViewQuery()

        {

            return Contact.tblcontact.ToList();

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
