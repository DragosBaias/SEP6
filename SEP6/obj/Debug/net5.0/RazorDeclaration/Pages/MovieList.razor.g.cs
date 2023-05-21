// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SEP6.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieList.razor"
using Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MovieList")]
    public partial class MovieList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 252 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieList.razor"
       
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
