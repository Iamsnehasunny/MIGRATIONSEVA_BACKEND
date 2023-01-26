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
    public class PoliceController : Controller
    {
        public ContextClass Police { get; set; }
        public PoliceController(ContextClass contextclass)
        {
            this.Police = contextclass;

        }
        [HttpPost("LoginPolice")]
        public IActionResult LoginPolice(Login user)
        {

            var userAvailable = Police.tblpolice.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();


            if (userAvailable == null)
            {
                return Ok("Failure");
            }

            return Ok("Success");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
