using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using WebApplication.Data;


namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieListController : ControllerBase
    {
        private readonly MyApiClient _data;

        public MovieListController([FromServices] MyApiClient data)
        {
            _data = data;
        }
        
        [HttpGet]
        public async Task<ActionResult<List<MovieList>>> GetMovieLists()
        {
            try
            {
                List<MovieList> movieList = await _data.GetMovieLists();
                return Ok(movieList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpGet]
        [Route("{movieListId}")]
        public async Task<ActionResult<MovieList>> GetMovieList([FromRoute] int movieListId)
        {
            try
            {
                MovieList movieList = await _data.GetMovieList(movieListId);
                return Ok(movieList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        [Route("addMovie")]
        public async Task<ActionResult> AddMovieToList([FromBody] Movie movie)
        {
            try
            {
                await _data.AddMovieToList(movie);
                
                return Ok();
            }catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        
        [HttpDelete]
        [Route("removeMovie/{movieId}")]
        public async Task<ActionResult> RemoveMovieFromList([FromRoute] int movieId)
        {
            try
            {
                await _data.RemoveMovieFromList(movieId);
                
                return Ok();
            }catch (Exception e) {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        
        
    }
}