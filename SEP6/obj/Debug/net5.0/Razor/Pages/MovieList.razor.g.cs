#pragma checksum "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b67afa68e2028b03551ca5abed808070367d8944"
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
#line 1 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
using Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/MovieList")]
    public partial class MovieList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddAttribute(2, "b-yelj34r6y8");
            __builder.AddMarkupContent(3, "<h3 class=\"title\" b-yelj34r6y8>Explore all movies</h3>\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "bar");
            __builder.AddAttribute(6, "b-yelj34r6y8");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "search-bar");
            __builder.AddAttribute(9, "b-yelj34r6y8");
#nullable restore
#line 10 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
         if (_searchMode)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "placeholder", "Search by title");
            __builder.AddAttribute(13, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                                       _searchQuery

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _searchQuery = __value, _searchQuery));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(15, "b-yelj34r6y8");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                              SearchMovies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "b-yelj34r6y8");
            __builder.AddContent(20, "Search");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "close-button");
            __builder.AddAttribute(24, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                                                   CloseSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "b-yelj34r6y8");
            __builder.AddMarkupContent(26, "<span b-yelj34r6y8>&times;</span>");
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                              ToggleSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "b-yelj34r6y8");
            __builder.AddContent(30, "Search Movies");
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "filter-bar");
            __builder.AddAttribute(34, "b-yelj34r6y8");
            __builder.AddMarkupContent(35, "<label for=\"filter-decade\" b-yelj34r6y8>Display all the most popular movies or filter them by decade:</label>\r\n        ");
            __builder.OpenElement(36, "select");
            __builder.AddAttribute(37, "id", "filter-decade");
            __builder.AddAttribute(38, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                                              FilterByDecade

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "b-yelj34r6y8");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", "all");
            __builder.AddAttribute(42, "b-yelj34r6y8");
            __builder.AddContent(43, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "option");
            __builder.AddAttribute(46, "value", "2020s");
            __builder.AddAttribute(47, "b-yelj34r6y8");
            __builder.AddContent(48, "2020s");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "option");
            __builder.AddAttribute(51, "value", "2010s");
            __builder.AddAttribute(52, "b-yelj34r6y8");
            __builder.AddContent(53, "2010s");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "2000s");
            __builder.AddAttribute(57, "b-yelj34r6y8");
            __builder.AddContent(58, "2000s");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.OpenElement(60, "option");
            __builder.AddAttribute(61, "value", "1990s");
            __builder.AddAttribute(62, "b-yelj34r6y8");
            __builder.AddContent(63, "1990s");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "option");
            __builder.AddAttribute(66, "value", "1980s");
            __builder.AddAttribute(67, "b-yelj34r6y8");
            __builder.AddContent(68, "1980s");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n            ");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "1970s");
            __builder.AddAttribute(72, "b-yelj34r6y8");
            __builder.AddContent(73, "1970s");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "option");
            __builder.AddAttribute(76, "value", "1960s");
            __builder.AddAttribute(77, "b-yelj34r6y8");
            __builder.AddContent(78, "1960s");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n            ");
            __builder.OpenElement(80, "option");
            __builder.AddAttribute(81, "value", "1950s");
            __builder.AddAttribute(82, "b-yelj34r6y8");
            __builder.AddContent(83, "1950s");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "movie-list");
            __builder.AddAttribute(87, "b-yelj34r6y8");
#nullable restore
#line 39 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
     foreach (var movie in _movies)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
         if(movie!=null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "movie-card");
            __builder.AddAttribute(90, "b-yelj34r6y8");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "movie-poster-container");
            __builder.AddAttribute(93, "b-yelj34r6y8");
#nullable restore
#line 45 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                     if (!string.IsNullOrEmpty(movie.PosterPath))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(94, "img");
            __builder.AddAttribute(95, "class", "movie-poster");
            __builder.AddAttribute(96, "src", "https://image.tmdb.org/t/p/w500/" + (
#nullable restore
#line 47 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                                                                                        movie.PosterPath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "alt", 
#nullable restore
#line 47 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                                                                                                                movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(98, "b-yelj34r6y8");
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(99, "<img class=\"fallback-poster\" src=\"fallback-image.jpg\" alt=\"No Poster Available\" b-yelj34r6y8>");
#nullable restore
#line 52 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "movie-details");
            __builder.AddAttribute(103, "b-yelj34r6y8");
            __builder.OpenElement(104, "h4");
            __builder.AddAttribute(105, "class", "movie-title");
            __builder.AddAttribute(106, "b-yelj34r6y8");
#nullable restore
#line 55 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
__builder.AddContent(107, movie.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                    ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "movie-info");
            __builder.AddAttribute(111, "b-yelj34r6y8");
            __builder.OpenElement(112, "p");
            __builder.AddAttribute(113, "class", "movie-release-date");
            __builder.AddAttribute(114, "b-yelj34r6y8");
            __builder.AddMarkupContent(115, "<strong b-yelj34r6y8><em b-yelj34r6y8>Release Date:</em></strong> ");
            __builder.OpenElement(116, "em");
            __builder.AddAttribute(117, "b-yelj34r6y8");
#nullable restore
#line 57 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
__builder.AddContent(118, movie.ReleaseDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(119, "\r\n                        ");
            __builder.OpenElement(120, "p");
            __builder.AddAttribute(121, "class", "movie-vote-average");
            __builder.AddAttribute(122, "b-yelj34r6y8");
            __builder.AddMarkupContent(123, "<strong b-yelj34r6y8><em b-yelj34r6y8>Vote Average:</em></strong> ");
            __builder.OpenElement(124, "em");
            __builder.AddAttribute(125, "b-yelj34r6y8");
#nullable restore
#line 58 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
__builder.AddContent(126, movie.VoteAverage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(127, "\r\n                        ");
            __builder.OpenElement(128, "p");
            __builder.AddAttribute(129, "class", "movie-vote-count");
            __builder.AddAttribute(130, "b-yelj34r6y8");
            __builder.AddMarkupContent(131, "<strong b-yelj34r6y8><em b-yelj34r6y8>Vote Count:</em></strong> ");
            __builder.OpenElement(132, "em");
            __builder.AddAttribute(133, "b-yelj34r6y8");
#nullable restore
#line 59 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
__builder.AddContent(134, movie.VoteCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
 if(_movies.Count>10)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "pagination");
            __builder.AddAttribute(137, "b-yelj34r6y8");
#nullable restore
#line 69 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
         if (_currentPage != 1)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(138, "button");
            __builder.AddAttribute(139, "class", "page-navigation");
            __builder.AddAttribute(140, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                                                      () => ChangePage(-1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "b-yelj34r6y8");
            __builder.AddContent(142, "Previous");
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(143, "span");
            __builder.AddAttribute(144, "class", "current-page");
            __builder.AddAttribute(145, "b-yelj34r6y8");
            __builder.AddContent(146, "Page ");
#nullable restore
#line 73 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
__builder.AddContent(147, _currentPage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(148, "\r\n        ");
            __builder.OpenElement(149, "button");
            __builder.AddAttribute(150, "class", "page-navigation");
            __builder.AddAttribute(151, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
                                                  () => ChangePage(1)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(152, "b-yelj34r6y8");
            __builder.AddContent(153, "Next");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 76 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(154, "<style b-yelj34r6y8>\r\n    \r\nhtml, body {\r\n        height: 100%;\r\n        margin: 0;\r\n        padding: 0;\r\n    }\r\n\r\nbody {\r\n    background-image: url(\'images/Background.jpg\');\r\n    background-size: cover;\r\n    background-position: center;\r\n    background-repeat: no-repeat;\r\n    background-attachment: fixed;\r\n}\r\n\r\n.container {\r\n        display: flex;\r\n        flex-wrap: wrap;\r\n        justify-content: center;\r\n        align-items: center;\r\n        min-height: 100vh;\r\n    }\r\n\r\n.title {\r\n    width: 100%;\r\n    text-align: center;\r\n    color: white;\r\n    font-family: \'Berlin Sans FB\', serif;\r\n    margin-bottom: 30px;\r\n}\r\n\r\n.movie-list {\r\n    display: flex;\r\n    flex-wrap: wrap;\r\n    justify-content: center;\r\n    align-items: center;\r\n    margin: 0;\r\n    padding: 0;\r\n}\r\n\r\n.movie-card {\r\n    width: 300px;\r\n    margin: 20px;\r\n    padding: 10px;\r\n    background-color: transparent;\r\n    border-radius: 5px;\r\n    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);\r\n}\r\n\r\n.movie-poster-container {\r\n    height: 400px;\r\n    display: flex;\r\n    justify-content: center;\r\n    align-items: center;\r\n}\r\n\r\n.movie-poster, .fallback-poster {\r\n    max-width: 100%;\r\n    max-height: 100%;\r\n}\r\n\r\n.fallback-poster {\r\n    object-fit: contain;\r\n    background-color: #ddd;\r\n    padding: 10px;\r\n}\r\n\r\n.movie-details {\r\n    padding: 10px;\r\n    height: 100%;\r\n    display: flex;\r\n    flex-direction: column;\r\n    justify-content: space-between;\r\n}\r\n\r\n.movie-title {\r\n    font-size: 18px;\r\n    font-weight: bold;\r\n    margin-bottom: 10px;\r\n    word-break: break-word;\r\n    text-align: center;\r\n}\r\n\r\n.movie-info {\r\n    flex-grow: 1;\r\n}\r\n\r\n.movie-release-date,\r\n.movie-vote-average,\r\n.movie-vote-count {\r\n    margin-bottom: 5px;\r\n}\r\n\r\n.pagination {\r\n    display: flex;\r\n    justify-content: center;\r\n    margin-top: 20px;\r\n}\r\n\r\n.page-navigation {\r\n    padding: 10px 20px;\r\n    margin: 0 5px;\r\n    background-color: #007bff;\r\n    color: #fff;\r\n    border: none;\r\n    border-radius: 3px;\r\n    cursor: pointer;\r\n}\r\n\r\n.current-page {\r\n    font-weight: bold;\r\n}\r\n\r\n.search-bar {\r\n    display: flex;\r\n    align-items: center;\r\n    justify-content: center;\r\n    margin-bottom: 20px;\r\n}\r\n\r\n.search-bar input {\r\n    padding: 5px;\r\n    font-size: 14px;\r\n    border: 1px solid #ccc;\r\n    border-radius: 3px;\r\n}\r\n\r\n.search-bar button {\r\n    padding: 5px 10px;\r\n    background-color: #007bff;\r\n    color: #fff;\r\n    border: none;\r\n    border-radius: 3px;\r\n    cursor: pointer;\r\n    margin-left: 10px;\r\n}\r\n\r\n.close-button {\r\n    padding: 5px;\r\n    background-color: #dc3545;\r\n    color: #fff;\r\n    border: none;\r\n    border-radius: 50%;\r\n    cursor: pointer;\r\n    margin-left: 10px;\r\n}\r\n\r\n.close-button span {\r\n    font-size: 12px;\r\n    line-height: 1;\r\n}\r\n\r\n.filter-bar {\r\n    display: flex;\r\n    align-items: center;\r\n    justify-content: center;\r\n    margin-bottom: 20px;\r\n}\r\n\r\n.filter-bar label {\r\n    margin-right: 10px;\r\n    background-color: #f5f5f5;\r\n    border-radius: 3px;\r\n    border: white 1px solid;\r\n    padding: 4px;\r\n}\r\n\r\n.filter-bar select {\r\n    padding: 5px;\r\n    font-size: 14px;\r\n    border: 1px solid #ccc;\r\n    border-radius: 3px;\r\n}\r\n\r\n</style>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 256 "C:\Users\Dragos\RiderProjects\SEP6\SEP6\Pages\MovieList.razor"
       
    private List<MovieDetails> _movies = new List<MovieDetails>();
    private int _currentPage = 1;
    private string _searchQuery = string.Empty;
    private bool _searchMode = false;
    TMDBApiClient _tmdbApiClient;

    protected override async Task OnInitializedAsync()
    {
        _tmdbApiClient = new TMDBApiClient("7f4f7ef07e4add825a6a5cedbbf03857");
        await LoadMovies();
    }

    private async Task LoadMovies()
    {
        
        if (string.IsNullOrEmpty(_searchQuery))
        {
            _movies = await _tmdbApiClient.GetMovies(_currentPage);
        }
        else
        {
            List<MovieDetails> moviesByTitle = new List<MovieDetails>();
            moviesByTitle.Add(await _tmdbApiClient.GetMovieByTitle(_searchQuery));
            _movies = moviesByTitle;
        }
    }

    private async Task ChangePage(int offset)
    {
        _currentPage += offset;
        if (_currentPage < 1)
            _currentPage = 1;

        await LoadMovies();
    }

    private async Task SearchMovies()
    {
        _currentPage = 1;
        await LoadMovies();
        _searchMode = true;
    }

    private async void CloseSearch()
    {
        _searchMode = false;
        _searchQuery = string.Empty;
        _currentPage = 1;
        await LoadMovies();
        StateHasChanged();
    }
    
    private async Task FilterByDecade(ChangeEventArgs e)
    {
        if (e.Value != null)
        {
            string decade = e.Value.ToString();
            if (decade.Equals("all"))
                _movies = await _tmdbApiClient.GetPopularMovies();
            else
            {
                _movies = await _tmdbApiClient.Get10MostPopularMoviesByDecade(int.Parse(decade.Replace("s","")));
            }
        }
        StateHasChanged();
    }

    private async Task ViewMostPopularMovies()
    {
        _movies = await _tmdbApiClient.GetPopularMovies();
        StateHasChanged();
    }

    private void ToggleSearch()
    {
        _searchMode = true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
