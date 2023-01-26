using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MigrationSeva_Backend.Data;
using MigrationSeva_Backend.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MigrationSeva_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ApplicationController : Controller
    {
        private List<Application> sts;

        public ContextClass Application { get; set; }

        public ApplicationController(ContextClass contextclass)
        {
            this.Application = contextclass;


        }
        [HttpPost("InsertApplication")]

        public async Task<ActionResult> InsertUser(Application cu)
        {

            Application.tblapplication.Add(cu);
            await Application.SaveChangesAsync();
            return Ok(cu);
        }



        [HttpGet("ViewApplicationById/{id}")]
        public async Task<ActionResult<Application>> ViewApplicationById(int id)
        {

            var appl = Application.tblapplication.Find(id);
            if (appl == null)
            {
                return NotFound();
            }

            return appl;
        }

        [HttpPost("UpdateApplication")]
        public IActionResult UpdateApplication(Application cu)
        {

            Application.tblapplication.Update(cu);
            Application.SaveChanges();
            return Ok(cu);
        }



        [HttpGet("Userviewapplications/{phone}")]
        public async Task<IActionResult> ViewApplicationByUser(string phone)
        {

            var details = Application.tblapplication.Where(c => c.Phoneno.Equals(phone)).ToList();


            return Ok(details);
        }

        [HttpGet("Policeviewapplications/{district}/{status}")]
        public async Task<IActionResult> ViewApplicationByPolice(string district, string status)
        {

            var details = Application.tblapplication.Where(c => c.District.Equals(district) && c.Status.Equals(status)).ToList();


            return Ok(details);
        }


        [HttpGet("viewapplicationsbystatus/{status}")]
        public async Task<IActionResult> ViewApplicationBystatus(string status)
        {

            var details = Application.tblapplication.Where(c => c.Status.Equals(status)).ToList();


            return Ok(details);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
