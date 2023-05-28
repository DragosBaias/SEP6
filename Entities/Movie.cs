using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities
{
    public class Movie
    {
        public Movie()
        {
            ID = 0;
            MovieID = 0;
        }

        [Key,Range(0,9999999),DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        
        [JsonPropertyName("MovieID")]
        public int MovieID { get; set; }
        
        
        [ForeignKey("MovieListID")]
        public int MovieListID { get; set; }
        
    }
}