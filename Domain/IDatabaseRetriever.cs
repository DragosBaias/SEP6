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
        public void AddMovie(int movieListId, int movieId);
        public void RemoveMovie(int movieListId, int movieId);
        


    }
}