using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;

namespace Domain
{
    public interface IDatabaseRetriever
    {

        public Task<User> RegisterUser(User user);
        public Task<User> LogIn(string username, string password);

        public Task<Movie> GetMovie(int id);

        public Task<MovieList> GetMovieList(int movieListId);
        public Task<List<MovieList>> GetMovieLists();
        public Task AddMovie(Movie movie);
        public Task RemoveMovie(int movieId);
        


    }
}