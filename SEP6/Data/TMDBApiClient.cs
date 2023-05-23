using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Domain;
using Entities;
using Newtonsoft.Json;

public class TMDBApiClient:IApiRetriever
{
    private readonly string _apiKey;
    private readonly HttpClient _httpClient;

    public TMDBApiClient(string apiKey)
    {
        _apiKey = apiKey;
        _httpClient = new HttpClient();
        _httpClient.BaseAddress = new Uri("https://api.themoviedb.org/3/");
    }

    public async Task<List<MovieDetails>> GetMovies(int page)
    {
        string requestUrl = $"discover/movie?api_key={_apiKey}&page={page}";

        HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<MovieListResponse>(responseBody);

        return result?.Results;
    }

    public async Task<List<MovieDetails>> GetPopularMovies()
    {
        string requestUrl = $"movie/popular?api_key={_apiKey}";

        HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<MovieListResponse>(responseBody);

        return result?.Results;
    }

    public async Task<MovieDetails> GetMovieByTitle(string title)
    {
        string encodedTitle = Uri.EscapeDataString(title);
        string requestUrl = $"search/movie?api_key={_apiKey}&query={encodedTitle}";

        HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<MovieListResponse>(responseBody);

        return result?.Results?.FirstOrDefault();
    }

    public async Task<List<MovieDetails>> Get10MostPopularMoviesByDecade(int decade)
    {
        int startYear=decade;
        int endYear = startYear + 9;

        string requestUrl = $"discover/movie?api_key={_apiKey}&sort_by=popularity.desc&primary_release_date.gte={startYear}-01-01&primary_release_date.lte={endYear}-01-01&page=1";

        HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
        response.EnsureSuccessStatusCode();

        string responseBody = await response.Content.ReadAsStringAsync();

        var result = JsonConvert.DeserializeObject<MovieListResponse>(responseBody);

        return result?.Results?.Take(10).ToList();
    }

    public async Task<List<MovieDetails>> GetHoFMovie()
    {
        List<MovieDetails> topMoviesByYear = new List<MovieDetails>();

        for (int currentYear = DateTime.Now.Year; currentYear > 1950; currentYear-- )
        {
           string requestUrl = $"discover/movie?api_key={_apiKey}&sort_by=popularity.desc&primary_release_date.gte={currentYear}-01-01&primary_release_date.lte={currentYear}-12-31&page=1";
                   HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);
                   response.EnsureSuccessStatusCode();
                   string responseBody = await response.Content.ReadAsStringAsync();
                   var result = JsonConvert.DeserializeObject<MovieListResponse>(responseBody);
                   topMoviesByYear.AddRange(result.Results.Take(1).ToList());
        }
        
        return topMoviesByYear;
    }
}


public class MovieListResponse
{
    public List<MovieDetails> Results { get; set; }
}
