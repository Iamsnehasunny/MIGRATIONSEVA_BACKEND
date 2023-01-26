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
    public class UserRegisterController : Controller
    {
        public ContextClass UserRegister { get; set; }

        public UserRegisterController(ContextClass contextclass)
        {
            this.UserRegister = contextclass;

        }
        [HttpPost("InsertUser")]

        public async Task<ActionResult> InsertUser(UserRegister cu)
        {

            UserRegister.tbluser.Add(cu);
            await UserRegister.SaveChangesAsync();
            return Ok(cu);
        }

        [HttpPost("LoginUser")]
        public IActionResult Login(Login user)
        {

            var userAvailable = UserRegister.tbluser.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();

            System.Console.WriteLine(userAvailable);
            if (userAvailable == null)
            {
                return Ok("Failure");
            }
            //  HttpContext.Session.SetInt32("Userid", userAvailable.Userid);
            return Ok("Success");
        }


        [HttpGet("CheckUser/{phone}")]
        public async Task<IActionResult> CheckUser(string phone)
        {

            var userAvailable = UserRegister.tbluser.Where(u => u.Phoneno.Equals(phone)).ToList();


            return Ok(userAvailable);
        }


        [HttpGet("GetPhone/{name}")]
        public async Task<IActionResult> GetPhone(string name)
        {
            var userAvailable = UserRegister.tbluser.Where(u => u.Username.Equals(name)).ToList();

            return Ok(userAvailable);
        }

    }
}
