#pragma checksum "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b5c1dbec51761e65141deb149930b5b93f14e5f"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP6.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
using SEP6.Temporary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
using Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
using SEP6.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/PublicLists")]
    public partial class PublicLists : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"page-title\">Public Lists</h3>\r\n");
            __builder.AddMarkupContent(1, "<p class=\"invitation\">Explore the favorite lists of other users.</p>\r\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "back-button");
            __builder.AddAttribute(4, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
                                      GoBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Back");
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
 if (_shownMovies.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p class=\"empty-message\">No favorite movies yet.</p>");
#nullable restore
#line 18 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "movie-list");
#nullable restore
#line 22 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
         foreach (var movieList in _shownMovies)
        {
            

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "movie-list-box");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "movie-list-movies");
#nullable restore
#line 27 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
                     foreach (var movie in movieList)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "movie-card");
            __builder.AddAttribute(15, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
                                                          ()=>OpenMovieOverview(movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "movie-poster-container");
#nullable restore
#line 31 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
                                 if (!string.IsNullOrEmpty(movie.PosterPath))
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "img");
            __builder.AddAttribute(19, "class", "movie-poster");
            __builder.AddAttribute(20, "src", "https://image.tmdb.org/t/p/w500/" + (
#nullable restore
#line 33 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
                                                                                                    movie.PosterPath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "alt", 
#nullable restore
#line 33 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
                                                                                                                            movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(22, "<img class=\"fallback-poster\" src=\"fallback-image.jpg\" alt=\"No Poster Available\">");
#nullable restore
#line 38 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "movie-details");
            __builder.OpenElement(26, "h4");
            __builder.AddAttribute(27, "class", "movie-title");
#nullable restore
#line 41 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
__builder.AddContent(28, movie.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "movie-info");
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "class", "movie-release-date");
            __builder.AddMarkupContent(34, "<strong>Release Date:</strong> ");
#nullable restore
#line 43 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
__builder.AddContent(35, movie.ReleaseDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                                    ");
            __builder.OpenElement(37, "p");
            __builder.AddAttribute(38, "class", "movie-vote-average");
            __builder.AddMarkupContent(39, "<strong>Vote Average:</strong> ");
#nullable restore
#line 44 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
__builder.AddContent(40, movie.VoteAverage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                    ");
            __builder.OpenElement(42, "p");
            __builder.AddAttribute(43, "class", "movie-vote-count");
            __builder.AddMarkupContent(44, "<strong>Vote Count:</strong> ");
#nullable restore
#line 45 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
__builder.AddContent(45, movie.VoteCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "<style>\r\n     body {\r\n            background-image: url(\'images/Background.jpg\');\r\n            background-size: cover;\r\n            background-position: center;\r\n            background-repeat: no-repeat;\r\n            background-attachment: fixed;\r\n            padding: 20px;\r\n        }\r\n         .page-title {\r\n                color: white;\r\n            }\r\n        \r\n            .empty-message {\r\n                color: white;\r\n            }\r\n        \r\n            .movie-list {\r\n                display: flex;\r\n                flex-wrap: wrap;\r\n                justify-content: center;\r\n                align-items: flex-start;\r\n            }\r\n        \r\n            .movie-list-box {\r\n                margin: 20px;\r\n                padding: 10px;\r\n                background-color: #1a1a1a;\r\n                border-radius: 5px;\r\n                box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);\r\n            }\r\n        \r\n            .movie-list-movies {\r\n                display: flex;\r\n                flex-wrap: wrap;\r\n                justify-content: center;\r\n                align-items: center;\r\n            }\r\n        \r\n            .movie-card {\r\n                width: 300px;\r\n                margin: 20px;\r\n                padding: 10px;\r\n                background-color: #222222;\r\n                border-radius: 5px;\r\n                box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);\r\n                display: flex;\r\n                flex-direction: column;\r\n                align-items: center;\r\n            }\r\n        \r\n            .movie-poster-container {\r\n                height: 400px;\r\n                display: flex;\r\n                justify-content: center;\r\n                align-items: center;\r\n            }\r\n        \r\n            .movie-poster,\r\n            .fallback-poster {\r\n                max-width: 100%;\r\n                max-height: 100%;\r\n            }\r\n        \r\n            .fallback-poster {\r\n                object-fit: contain;\r\n                background-color: #ddd;\r\n                padding: 10px;\r\n            }\r\n        \r\n            .movie-details {\r\n                padding: 10px;\r\n                height: 100%;\r\n                display: flex;\r\n                flex-direction: column;\r\n                justify-content: space-between;\r\n            }\r\n        \r\n            .movie-title {\r\n                font-size: 18px;\r\n                font-weight: bold;\r\n                margin-bottom: 10px;\r\n                word-break: break-word;\r\n                text-align: center;\r\n                color: white;\r\n            }\r\n        \r\n            .movie-info {\r\n                flex-grow: 1;\r\n            }\r\n        \r\n            .movie-release-date,\r\n            .movie-vote-average,\r\n            .movie-vote-count {\r\n                margin-bottom: 5px;\r\n                color: white;\r\n            }\r\n\r\n    .invitation {\r\n        color: white;\r\n        font-size: 20px;\r\n        margin-bottom: 20px;\r\n    }\r\n\r\n    .back-button {\r\n        position: absolute;\r\n        top: 20px;\r\n        right: 20px;\r\n        padding: 10px;\r\n        background-color: #1a1a1a;\r\n        color: white;\r\n        border: none;\r\n        border-radius: 5px;\r\n        cursor: pointer;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\PublicLists.razor"
       
    private List<List<MovieDetails>> _shownMovies = new();

    protected override async Task OnInitializedAsync()
    {
        _shownMovies = await LoadLists();
    }

    private async Task<List<List<MovieDetails>>> LoadLists()
    {
        List<Entities.MovieList> movieLists = await ApiClient.GetMovieLists();
        List<List<MovieDetails>> shownMovies = new List<List<MovieDetails>>();

        foreach (var movieList in movieLists)
        {
            if(movieList.Movies != null)
            {
                List<MovieDetails> movieDetailsList = new List<MovieDetails>();
                foreach (var movie in movieList.Movies.Take(3))
                {
                    if(movie != null)
                    {
                        var movieDetails = await TmdbClient.GetMovie(movie.MovieID);
                        movieDetailsList.Add(movieDetails);
                    }
                }
                shownMovies.Add(movieDetailsList);
            }
        }

        return shownMovies;
    }
    
    private void OpenMovieOverview(MovieDetails movie)
    {
        DataSession.Instance.MovieDetails = movie;
        NavigationManager.NavigateTo("/MovieOverview");
    }
    
    private void GoBack()
    {
        NavigationManager.NavigateTo("/MovieList");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MyApiClient ApiClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApiRetriever TmdbClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataSession DataSession { get; set; }
    }
}
#pragma warning restore 1591
