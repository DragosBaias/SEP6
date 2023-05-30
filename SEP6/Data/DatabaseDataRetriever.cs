using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Entities;
using Microsoft.EntityFrameworkCore;
using SEP6.DBContext;

namespace SEP6.Data
{
    public class DatabaseDataRetriever : IDatabaseRetriever
    {
        private DbContextOptions<ImperiumDBContext> options;

        public DatabaseDataRetriever()
        {
            options = new DbContextOptionsBuilder<ImperiumDBContext>()
                .UseSqlServer("Data Source=imperiummovie.database.windows.net;Initial Catalog=ImpMovieDB;User ID=304170@viauc.dk;Connect Timeout=30;Encrypt=True;TrustServerCertificate=False;Authentication=\"Active Directory Interactive\";ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                .Options;
        }

        public async Task<User> RegisterUser(User user)
        {
            using var context = new ImperiumDBContext(options);
            MovieList movieList = new MovieList();
            movieList.MovieListID = GenerateNewMovieListId();
            user.MovieList = movieList;
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            return user;
        }

        public async Task<User> LogIn(string username, string password)
        {
            await using var context = new ImperiumDBContext(options);
            return await context.Users.Include(m => m.MovieList).FirstOrDefaultAsync(m => m.Username.Equals(username) && m.Password.Equals(password));
        }

        public async Task<Movie> GetMovie(int id)
        {
            await using var context = new ImperiumDBContext(options);
            return await context.Movie.FindAsync(id);
        }

        public async Task<MovieList> GetMovieList(int movieListId)
        {
            using var context = new ImperiumDBContext(options);
            var movieList = await context.MovieList.Include(m => m.Movies).FirstOrDefaultAsync(m => m.MovieListID == movieListId);
            return movieList;
        }

        public async Task<List<MovieList>> GetMovieLists()
        {
            using var context = new ImperiumDBContext(options);
            return context.MovieList.Include(m => m.Movies).ToList();
        }

        public async Task AddMovie( Movie movie)
        {
            using var context = new ImperiumDBContext(options);
            context.Movie.Add(movie);
            await context.SaveChangesAsync();
        }

        public async Task RemoveMovie(int movieId)
        {
            using var context = new ImperiumDBContext(options);
            Movie movie = await context.Movie.FirstAsync(m => m.MovieID == movieId);
            context.Movie.Remove(movie);
            await context.SaveChangesAsync();

        }

        private int GenerateNewMovieListId()
        {
            using var context = new ImperiumDBContext(options);
            int newId;

            do
            {
                newId = new Random().Next(100000, 999999);
            } while (context.MovieList.Any(m => m.MovieListID == newId));

            return newId;
        }
    }
}
