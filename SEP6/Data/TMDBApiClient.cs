using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Entities;
using RestSharp;
using Newtonsoft.Json;

public class TMDBApiClient
{
    private readonly string apiKey;
    private HttpClient client;

    public TMDBApiClient(string apiKey)
    {
        this.apiKey = apiKey;
    }
    
    public async Task<List<Movie>> GetMovies()
    {
        string apiUrl = "https://api.themoviedb.org/3/";

        // Create an instance of HttpClient
        client = new HttpClient();

        // Set the base URL for TMDb API
        client.BaseAddress = new Uri(apiUrl);

        // Send a GET request to retrieve the list of movies
        HttpResponseMessage response = await client.GetAsync($"movie/popular?api_key={apiKey}");

        if (response.IsSuccessStatusCode)
        {
            // Read the response content
            string responseBody = await response.Content.ReadAsStringAsync();

            // Deserialize the response JSON into objects
            var result = JsonConvert.DeserializeObject<MovieListResponse>(responseBody);

            Console.WriteLine(responseBody);
            // Process the movie data
            foreach (var movie in result.Results)
            {
                Console.WriteLine($"Title: {movie.Title}");
                Console.WriteLine($"Poster: https://image.tmdb.org/t/p/w500{movie.Poster_Path}");
                Console.WriteLine();
            }
            
            client.Dispose();
            return result.Results;
        }
        else
        {
            
            Console.WriteLine("Request failed with status code: " + response.StatusCode);
            
            client.Dispose();
            return null;
        }

        // Dispose the HttpClient when finished
        
    }


    public class MovieListResponse
    {
        public List<Movie> Results { get; set; }
    }
    
    public class Movie
    {
        public string Title { get; set; }
        public string Poster_Path { get; set; }
    }
}