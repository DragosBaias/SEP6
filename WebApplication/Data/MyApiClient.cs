using System.Collections.Generic;
using Entities;

namespace WebApplication.Data
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class MyApiClient
    {
        private readonly string baseUrl;
        private readonly HttpClient httpClient;

        public MyApiClient(string baseUrl)
        {
            this.baseUrl = baseUrl;
            this.httpClient = new HttpClient();
        }

        public async Task<User> LogIn(string username, string password)
        {
            string apiUrl = $"User/{username}/{password}";

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(GetFullUrl(apiUrl));
                response.EnsureSuccessStatusCode();
                string responseContent = await response.Content.ReadAsStringAsync();
                User user = JsonConvert.DeserializeObject<User>(responseContent);
                return user;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task RegisterUser(User user)
        {
            string apiUrl = "User/register";

            try
            {
                string userJson = JsonConvert.SerializeObject(user);
                StringContent content = new StringContent(userJson, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(GetFullUrl(apiUrl), content);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        
        public async Task<MovieList> GetMovieList(int movieListId)
        {
            string apiUrl = $"MovieList/{movieListId}";

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(GetFullUrl(apiUrl));
                response.EnsureSuccessStatusCode();
                string responseContent = await response.Content.ReadAsStringAsync();
                MovieList movieList = JsonConvert.DeserializeObject<MovieList>(responseContent);
                return movieList;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task AddMovieToList(Movie movie)
        {
            string apiUrl = $"MovieList/addMovie";

            try
            {
                string movieJson = JsonConvert.SerializeObject(movie);
                StringContent content = new StringContent(movieJson, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync(GetFullUrl(apiUrl), content);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public async Task RemoveMovieFromList(int movieId)
        {
            string apiUrl = $"MovieList/removeMovie/{movieId}";

            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync(GetFullUrl(apiUrl));
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        
        public async Task<Movie> GetMovie(int movieId)
        {
            string apiUrl = $"Movie/{movieId}";

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(GetFullUrl(apiUrl));
                response.EnsureSuccessStatusCode();
                string responseContent = await response.Content.ReadAsStringAsync();
                Movie movie = JsonConvert.DeserializeObject<Movie>(responseContent);
                return movie;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }


        private string GetFullUrl(string apiUrl)
        {
            return $"{baseUrl}/{apiUrl}";
        }

        public async Task<List<MovieList>> GetMovieLists()
        {
            string apiUrl = $"MovieList";

            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(GetFullUrl(apiUrl));
                response.EnsureSuccessStatusCode();
                string responseContent = await response.Content.ReadAsStringAsync();
                List<MovieList> movieLists = JsonConvert.DeserializeObject<List<MovieList>>(responseContent);
                return movieLists;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }

}