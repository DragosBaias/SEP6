#pragma checksum "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fc9ce1a9b097a7c0a29254aefe1d87907619ce2"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP6.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
using SEP6.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
using SEP6.Temporary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
using Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/FavouriteList")]
    public partial class FavouriteList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"title\">Explore all movies</h1>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "bar");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "search-bar");
#nullable restore
#line 16 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
         if (_searchMode)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "placeholder", "Search by title");
            __builder.AddAttribute(8, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                                      _searchQuery

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _searchQuery = __value, _searchQuery));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "class", "custom-button");
            __builder.AddAttribute(13, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                                                    SearchMovies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "button");
            __builder.AddAttribute(17, "class", "close-button");
            __builder.AddAttribute(18, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                                                   CloseSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "<span>&times;</span>");
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "custom-button");
            __builder.AddAttribute(22, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                                                    ToggleSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Search Movies");
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        \r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "back-button");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn-back");
            __builder.AddAttribute(29, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                                       NavigateBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Back");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "movie-list");
#nullable restore
#line 35 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
     foreach (var movie in _movies)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
         if (movie != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "movie-card");
            __builder.AddAttribute(36, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                                              ()=>OpenMovieOverview(movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "movie-poster-container");
#nullable restore
#line 41 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                     if (!string.IsNullOrEmpty(movie.PosterPath))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "img");
            __builder.AddAttribute(40, "class", "movie-poster");
            __builder.AddAttribute(41, "src", "https://image.tmdb.org/t/p/w500/" + (
#nullable restore
#line 43 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                                                                                        movie.PosterPath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "alt", 
#nullable restore
#line 43 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                                                                                                                movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(43, "<img class=\"fallback-poster\" src=\"fallback-image.jpg\" alt=\"No Poster Available\">");
#nullable restore
#line 48 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "movie-details");
            __builder.OpenElement(47, "h4");
            __builder.AddAttribute(48, "class", "movie-title");
#nullable restore
#line 51 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
__builder.AddContent(49, movie.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "movie-info");
            __builder.OpenElement(53, "p");
            __builder.AddAttribute(54, "class", "movie-release-date");
            __builder.AddMarkupContent(55, "<strong><em>Release Date:</em></strong> ");
            __builder.OpenElement(56, "em");
#nullable restore
#line 53 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
__builder.AddContent(57, movie.ReleaseDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.OpenElement(59, "p");
            __builder.AddAttribute(60, "class", "movie-vote-average");
            __builder.AddMarkupContent(61, "<strong><em>Vote Average:</em></strong> ");
            __builder.OpenElement(62, "em");
#nullable restore
#line 54 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
__builder.AddContent(63, movie.VoteAverage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.OpenElement(65, "p");
            __builder.AddAttribute(66, "class", "movie-vote-count");
            __builder.AddMarkupContent(67, "<strong><em>Vote Count:</em></strong> ");
            __builder.OpenElement(68, "em");
#nullable restore
#line 55 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
__builder.AddContent(69, movie.VoteCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                     if(_searchQuery!=String.Empty)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "add-to-favorite-container");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "class", "add-to-favorite-button");
            __builder.AddAttribute(74, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                                                                             () => AddToFavorites(movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(75, "Add to Favorite");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "add-to-favorite-container");
            __builder.OpenElement(78, "button");
            __builder.AddAttribute(79, "class", "add-to-favorite-button");
            __builder.AddAttribute(80, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                                                                             () => RemoveFromFavourites(movie)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(81, "Remove from Favorite");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(83, "<style>\r\n    .custom-button {\r\n        background-color: #ff6b6b;\r\n        color: #ffffff;\r\n        border: none;\r\n        outline: none;\r\n        padding: 10px 20px;\r\n        cursor: pointer;\r\n        border-radius: 5px;\r\n        margin-top: 10px;\r\n    }\r\n\r\n    body {\r\n        background-image: url(\'images/Background.jpg\');\r\n        background-size: cover;\r\n        background-position: center;\r\n        background-repeat: no-repeat;\r\n        background-attachment: fixed;\r\n    }\r\n    \r\n    .back-button {\r\n            position: absolute;\r\n            top: 10px;\r\n            right: 10px;\r\n        }\r\n    \r\n        .btn-back {\r\n            padding: 5px 10px;\r\n            background-color: #ff6b6b;\r\n            color: #fff;\r\n            border: none;\r\n            border-radius: 3px;\r\n            margin: 25px;\r\n            cursor: pointer;\r\n        }\r\n\r\n    .search-bar {\r\n            display: flex;\r\n            align-items: center;\r\n            justify-content: center;\r\n            margin-bottom: 20px;\r\n        }\r\n    \r\n        .search-bar input {\r\n            padding: 5px;\r\n            font-size: 14px;\r\n            border: 1px solid #ccc;\r\n            border-radius: 3px;\r\n        }\r\n    \r\n        .search-bar button {\r\n            padding: 5px 10px;\r\n            background-color: #ff6b6b;\r\n            color: #fff;\r\n            border: none;\r\n            border-radius: 3px;\r\n            cursor: pointer;\r\n            margin-left: 10px;\r\n        }\r\n    \r\n        .close-button {\r\n            padding: 5px;\r\n            background-color: #dc3545;\r\n            color: #fff;\r\n            border: none;\r\n            border-radius: 50%;\r\n            cursor: pointer;\r\n            margin-left: 10px;\r\n        }\r\n    \r\n        .close-button span {\r\n            font-size: 12px;\r\n            line-height: 1;\r\n        }\r\n\r\n    .title {\r\n            width: 100%;\r\n            text-align: center;\r\n            color: white;\r\n            font-size: 35px;\r\n            font-family: Amiri,serif;\r\n            margin: 30px;\r\n        }\r\n\r\n    .logo-simple {\r\n        width: 300px;\r\n        height: auto;\r\n        margin-bottom: 10px;\r\n    }\r\n\r\n    .movie-list {\r\n        display: flex;\r\n        flex-wrap: wrap;\r\n        justify-content: center;\r\n        align-items: center;\r\n        margin: 0;\r\n        padding: 0;\r\n    }\r\n\r\n    .movie-card {\r\n        width: 300px;\r\n        margin: 20px;\r\n        padding: 10px;\r\n        background-color: transparent;\r\n        border-radius: 5px;\r\n        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);\r\n        display: flex;\r\n        flex-direction: column;\r\n        align-items: center;\r\n        cursor: pointer;\r\n    }\r\n\r\n    .movie-poster-container {\r\n        height: 400px;\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n    }\r\n\r\n    .movie-poster,\r\n    .fallback-poster {\r\n        max-width: 100%;\r\n        max-height: 100%;\r\n    }\r\n\r\n    .fallback-poster {\r\n        object-fit: contain;\r\n        background-color: #ddd;\r\n        padding: 10px;\r\n    }\r\n\r\n    .movie-details {\r\n        padding: 10px;\r\n        height: 100%;\r\n        display: flex;\r\n        flex-direction: column;\r\n        justify-content: space-between;\r\n    }\r\n\r\n    .movie-title {\r\n        font-size: 18px;\r\n        font-weight: bold;\r\n        margin-bottom: 10px;\r\n        word-break: break-word;\r\n        text-align: center;\r\n        color: white;\r\n    }\r\n\r\n    .movie-info {\r\n        flex-grow: 1;\r\n    }\r\n\r\n    .movie-release-date,\r\n    .movie-vote-average,\r\n    .movie-vote-count {\r\n        margin-bottom: 5px;\r\n        color: white;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\FavouriteList.razor"
       
    private  List<MovieDetails> _movies = new();
    private string _searchQuery = string.Empty;
    private bool _searchMode = false;
    
    protected override async Task OnInitializedAsync()
    {
        await LoadMovies();
    }
    
    private async Task LoadMovies()
    {

        if (string.IsNullOrEmpty(_searchQuery))
        {
            Entities.MovieList movieList = await DatabaseRetriever.GetMovieList(DataSession.User.MovieListID);
            foreach (var movie in movieList.Movies)
            {
                _movies.Add(await TmdbClient.GetMovie(movie.MovieID));
            }
        }
        else
        {
            List<MovieDetails> moviesByTitle = new List<MovieDetails>();
            moviesByTitle.Add(await TmdbClient.GetMovieByTitle(_searchQuery));
            _movies = moviesByTitle;
        }
    }
    
    private void NavigateBack()
    {
        NavigationManager.NavigateTo("/MovieList");
    }
    
    private void OpenMovieOverview(MovieDetails movie)
    {
        DataSession.Instance.MovieDetails = movie;
        NavigationManager.NavigateTo("/MovieOverview");
    }
    
    private async Task AddToFavorites(MovieDetails movie)
    {
        await DatabaseRetriever.AddMovie(new Movie { MovieID = Convert.ToInt32(movie.Id),MovieListID = DataSession.User.MovieListID });
    }
    
    private async Task RemoveFromFavourites (MovieDetails movieDetails)
    {
        await DatabaseRetriever.RemoveMovie(Convert.ToInt32(movieDetails.Id));
        await LoadMovies();
    }
    private async Task SearchMovies()
    {
        await LoadMovies();
        _searchMode = true;
    }

    private async void CloseSearch()
    {
        _searchMode = false;
        _searchQuery = string.Empty;
        await LoadMovies();
        StateHasChanged();
    }
    private void ToggleSearch()
    {
        _searchMode = true;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataSession DataSession { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApiRetriever TmdbClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDatabaseRetriever DatabaseRetriever { get; set; }
    }
}
#pragma warning restore 1591
