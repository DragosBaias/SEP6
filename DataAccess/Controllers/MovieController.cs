using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace DataAccess.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private readonly IDatabaseRetriever _data;
        
        public MovieController([FromServices] IDatabaseRetriever data)
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