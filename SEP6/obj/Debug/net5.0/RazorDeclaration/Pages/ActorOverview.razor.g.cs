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
#line 2 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\ActorOverview.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\ActorOverview.razor"
using SEP6.Temporary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\ActorOverview.razor"
using Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ActorOverview")]
    public partial class ActorOverview : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 175 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\ActorOverview.razor"
       
    protected override async Task OnInitializedAsync()
    {
        if (DataSession.CastMember != null)
        {
            await LoadMostPopularMovies();
        }
    }

    private async Task LoadMostPopularMovies()
    {
        var actorId = DataSession.CastMember.Id;
        var movies = new List<MovieDetails>();//await TmdbClient.GetMostPopularMoviesByActor(actorId);

        if (movies != null)
        {
            DataSession.CastMember.MostPopularMovies = movies;
        }
        else
            Console.WriteLine("movies is null");

        StateHasChanged();
    }

    private void NavigateBack()
    {
        NavigationManager.NavigateTo("/ActorList");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDatabaseRetriever TmdbClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataSession DataSession { get; set; }
    }
}
#pragma warning restore 1591
