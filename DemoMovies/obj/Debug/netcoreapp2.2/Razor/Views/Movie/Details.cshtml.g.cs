#pragma checksum "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Movie\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec8f2b9d0c71da5a99f00e76fdc8b79d680cea5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Details), @"mvc.1.0.view", @"/Views/Movie/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Movie/Details.cshtml", typeof(AspNetCore.Views_Movie_Details))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec8f2b9d0c71da5a99f00e76fdc8b79d680cea5", @"/Views/Movie/Details.cshtml")]
    public class Views_Movie_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DemoMovies.ViewModels.MovieDetailsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Movie\Details.cshtml"
   
    Layout = "_Layout";
    ViewBag.PageName = "Movie Details";

#line default
#line hidden
            BeginContext(119, 63, true);
            WriteLiteral("\n    <div class=\"movie-details\">\n        <img class=\"movie-img\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 182, "\"", 203, 1);
#line 9 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Movie\Details.cshtml"
WriteAttributeValue("", 188, Model.ImageUrl, 188, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(204, 37, true);
            WriteLiteral(" />\n        <div class=\"movie-title\">");
            EndContext();
            BeginContext(242, 11, false);
#line 10 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Movie\Details.cshtml"
                            Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(253, 2, true);
            WriteLiteral(" (");
            EndContext();
            BeginContext(256, 18, false);
#line 10 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Movie\Details.cshtml"
                                          Write(Model.YearReleased);

#line default
#line hidden
            EndContext();
            BeginContext(274, 56, true);
            WriteLiteral(")</div>\n        <div class=\"movie-desc\">\n            <p>");
            EndContext();
            BeginContext(331, 17, false);
#line 12 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Movie\Details.cshtml"
          Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(348, 60, true);
            WriteLiteral("</p>\n        </div>\n        <div class=\"movie-genre\">Genre: ");
            EndContext();
            BeginContext(409, 11, false);
#line 14 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Movie\Details.cshtml"
                                   Write(Model.Genre);

#line default
#line hidden
            EndContext();
            BeginContext(420, 80, true);
            WriteLiteral("</div>\n        <div class=\"movie-cast\">\n            Cast:\n                <span>");
            EndContext();
            BeginContext(501, 10, false);
#line 17 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Movie\Details.cshtml"
                 Write(Model.Cast);

#line default
#line hidden
            EndContext();
            BeginContext(511, 77, true);
            WriteLiteral("</span>\n        </div>\n        <div class=\"movie-date-created\">Date Created: ");
            EndContext();
            BeginContext(589, 17, false);
#line 19 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Movie\Details.cshtml"
                                                 Write(Model.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(606, 40, true);
            WriteLiteral("</div>\n        <div class=\"movie-views\">");
            EndContext();
            BeginContext(647, 11, false);
#line 20 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Movie\Details.cshtml"
                            Write(Model.Views);

#line default
#line hidden
            EndContext();
            BeginContext(658, 24, true);
            WriteLiteral(" Views</div>\n    </div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemoMovies.ViewModels.MovieDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
