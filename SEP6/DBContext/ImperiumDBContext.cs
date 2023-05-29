using Entities;
using Microsoft.EntityFrameworkCore;

namespace SEP6.DBContext
{
    public class ImperiumDBContext: DbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public DbSet<MovieList> MovieList { get; set; }
        public DbSet<User> Users { get; set; }

        public ImperiumDBContext(DbContextOptions<ImperiumDBContext> options) : base(options)
        {
            
        }
        
    }
}