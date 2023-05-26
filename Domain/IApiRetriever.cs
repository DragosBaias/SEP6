using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace Domain
{
    public interface IApiRetriever
    {
        public Task<List<MovieDetails>> GetMovies(int page);
        
        public Task<List<MovieDetails>> GetPopularMovies();

        public Task<MovieDetails> GetMovieByTitle(string title);

        public Task<List<MovieDetails>> Get10MostPopularMoviesByDecade(int decade);

        public Task<List<MovieDetails>> GetHoFMovie();
        Task<MovieDetails> GetMovie(int movieMovieId);
    }
}