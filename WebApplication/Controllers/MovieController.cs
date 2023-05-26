using System;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Data;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private readonly MyApiClient _data;
        
        public MovieController([FromServices] MyApiClient data)
        {
            _data = data;
        }
        
        [HttpGet]
        [Route("{movieId}")]
        public async Task<ActionResult<Movie>> GetMovie([FromRoute] int movieId)
        {
            try
            {
                Movie movie = await _data.GetMovie(movieId);
                return Ok(movie);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        
    }
}