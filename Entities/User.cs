using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Entities
{
    public class User
    {
        public User()
        {
        }

        [Key]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [ForeignKey("MovieListId")]
        public int MovieListID { get; set; }
        public MovieList MovieList { get; set; }
        
    }
}