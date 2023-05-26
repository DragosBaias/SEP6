using System;
using System.Threading.Tasks;
using Domain;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace DataAccess.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IDatabaseRetriever _data;

        public UserController([FromServices] IDatabaseRetriever data)
        {
            _data = data;
        }
        
        [HttpGet]
        [Route("{username}/{password}")]
        public async Task<ActionResult<User>> LogIn([FromRoute] string username,string password)
        {
            try
            {
                User user = await _data.LogIn(username,password);
                return Ok(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        [Route("register")]
        public async Task<ActionResult> RegisterUser([FromBody] User user)
        {
            try
            {
                await _data.RegisterUser(user);
                
                return Ok();
            }catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}