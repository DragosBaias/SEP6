using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Movie
    {
        public Movie()
        {
            MovieID = 0;
        }

        [Key,Range(0,9999999),DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieID { get; set; }
        
    }
}