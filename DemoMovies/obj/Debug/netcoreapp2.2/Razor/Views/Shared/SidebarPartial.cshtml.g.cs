#pragma checksum "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "822794e74d41400d9595847e46ee8f09fdea5ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_SidebarPartial), @"mvc.1.0.view", @"/Views/Shared/SidebarPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/SidebarPartial.cshtml", typeof(AspNetCore.Views_Shared_SidebarPartial))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"822794e74d41400d9595847e46ee8f09fdea5ddf", @"/Views/Shared/SidebarPartial.cshtml")]
    public class Views_Shared_SidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DemoMovies.Service.Dto.SideBarData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white; text-decoration:none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(100, 114, true);
            WriteLiteral("\r\n    <div style=\"width:100%; background-color:#343a40; color:white; padding:20px\">\r\n        <h2>Top Movies</h2>\r\n");
            EndContext();
#line 7 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
         foreach (var movie in Model.TopViews)
        {
            if (movie.IsApproved)
            {

#line default
#line hidden
            BeginContext(323, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(339, 445, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "822794e74d41400d9595847e46ee8f09fdea5ddf4353", async() => {
                BeginContext(453, 123, true);
                WriteLiteral("\r\n                    <div style=\"padding:5px; background-color:#a8a8a8;  margin:5px;\">\r\n                        <p>Title: ");
                EndContext();
                BeginContext(577, 11, false);
#line 13 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
                             Write(movie.Title);

#line default
#line hidden
                EndContext();
                BeginContext(588, 49, true);
                WriteLiteral("  </p>\r\n                        <p>Date created: ");
                EndContext();
                BeginContext(638, 40, false);
#line 14 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
                                    Write(movie.DateCreated.ToString("yyyy-MM-dd"));

#line default
#line hidden
                EndContext();
                BeginContext(678, 40, true);
                WriteLiteral("</p>\r\n                        <p>Views: ");
                EndContext();
                BeginContext(719, 11, false);
#line 15 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
                             Write(movie.Views);

#line default
#line hidden
                EndContext();
                BeginContext(730, 50, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 11 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
                                                                 WriteLiteral(movie.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(784, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(812, 32, true);
            WriteLiteral("        <h2>Recent Movies</h2>\r\n");
            EndContext();
#line 21 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
         foreach (var movie in Model.RecentlyCreated)
        {
            if (movie.IsApproved)
            {

#line default
#line hidden
            BeginContext(960, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(976, 445, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "822794e74d41400d9595847e46ee8f09fdea5ddf9012", async() => {
                BeginContext(1090, 123, true);
                WriteLiteral("\r\n                    <div style=\"padding:5px; background-color:#a8a8a8;  margin:5px;\">\r\n                        <p>Title: ");
                EndContext();
                BeginContext(1214, 11, false);
#line 27 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
                             Write(movie.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1225, 49, true);
                WriteLiteral("  </p>\r\n                        <p>Date created: ");
                EndContext();
                BeginContext(1275, 40, false);
#line 28 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
                                    Write(movie.DateCreated.ToString("yyyy-MM-dd"));

#line default
#line hidden
                EndContext();
                BeginContext(1315, 40, true);
                WriteLiteral("</p>\r\n                        <p>Views: ");
                EndContext();
                BeginContext(1356, 11, false);
#line 29 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
                             Write(movie.Views);

#line default
#line hidden
                EndContext();
                BeginContext(1367, 50, true);
                WriteLiteral("</p>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
                                                                 WriteLiteral(movie.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1421, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "D:\Academy\MVC\MyMovies-master\DemoMovies\Views\Shared\SidebarPartial.cshtml"
            }
        }

#line default
#line hidden
            BeginContext(1449, 10, true);
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemoMovies.Service.Dto.SideBarData> Html { get; private set; }
    }
}
#pragma warning restore 1591