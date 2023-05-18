using System;
using RestSharp;

namespace DataAccess.Data
{
    public class HttpRetriever
    {
        public HttpRetriever()
        {
            var client = new RestClient("https://api.themoviedb.org/3/authentication");
            var request = new RestRequest();
            request.AddHeader("accept", "application/json");
            request.AddHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiI3ZjRmN2VmMDdlNGFkZDgyNWE2YTVjZWRiYmYwMzg1NyIsInN1YiI6IjY0NjUwZDJjMDI4NDIwMDE3MDA2OGJkNCIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.C_oznqoKvY5zuX68I6QEj3--y-yxA1P6P1ZSfydPP6o");
            var response = client.Execute(request);
            Console.WriteLine(response.Content);
        }
    }
}