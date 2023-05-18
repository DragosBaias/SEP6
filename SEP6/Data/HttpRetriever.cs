using System;
using System.IO;
using System.Net;
using RestSharp;

namespace SEP6.Data
{
    public class HttpRetriever
    {
        public HttpRetriever(string searchText, int page)
        {
            int pageNo = Convert.ToInt32(page) == 0 ? 1 : Convert.ToInt32(page);
  
            /*Calling API https://developers.themoviedb.org/3/search/search-people */
            string apiKey = "3356865d41894a2fa9bfa84b2b5f59bb";
            HttpWebRequest apiRequest = WebRequest.Create("https://api.themoviedb.org/3/search/person?api_key=" + apiKey + "&language=en-US&query=" + searchText + "&page=" + pageNo + "&include_adult=false") as HttpWebRequest;
  
            string apiResponse = "";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3
                                                   | SecurityProtocolType.Tls
                                                   | SecurityProtocolType.Tls11
                                                   | SecurityProtocolType.Tls12;
            using (HttpWebResponse response = apiRequest.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                apiResponse = reader.ReadToEnd();
                Console.WriteLine(apiResponse);
            }
        }
    }
}