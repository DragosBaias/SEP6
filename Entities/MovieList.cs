using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities
{
    public class MovieList
    {
        public MovieList()
        {
        }

        [Key,Range(0,999999),DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieListID { get; set; }
        
        
        [JsonPropertyName("movies")]
        public ICollection<Movie> Movies { get; set; }
    }
}