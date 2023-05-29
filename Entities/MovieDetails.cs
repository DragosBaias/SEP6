using System.Collections.Generic;
using Newtonsoft.Json;

namespace Entities
{
    public class MovieDetails
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }

        [JsonProperty("release_date")]
        public string ReleaseDate { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("vote_average")]
        public double VoteAverage { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("popularity")]
        public double Popularity { get; set; }
        public List<CastMember> TopActors { get; set; }

        [JsonIgnore] // Exclude from JSON serialization
        public MovieCredits Credits { get; set; }
    }

    public class MovieCredits
    {
        public string Id { get; set; }
        [JsonProperty("cast")]
        public List<CastMember> Cast { get; set; }
        [JsonProperty("popularity")]
        public double Popularity { get; set; }
    }


    public class PersonCredits
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cast")]
        public List<MovieCredits> Cast { get; set; }
    }
    


    public class CastMember
    {
        public string Id { get; set; }
        [JsonProperty("name")]
        public string FullName { get; set; }

        [JsonProperty("profile_path")]
        public string ProfilePicturePath { get; set; }
        
        [JsonIgnore] // Exclude from JSON serialization
        public List<MovieDetails> MostPopularMovies { get; set; }
    }
}