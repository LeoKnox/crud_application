#pragma checksum "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23ead8010f22eb08228032f54fde7f44139d6ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Big_One), @"mvc.1.0.view", @"/Views/Big/One.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Big/One.cshtml", typeof(AspNetCore.Views_Big_One))]
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
#line 1 "/Users/Aelien/Documents/c#/BigProject/Views/_ViewImports.cshtml"
using BigProject;

#line default
#line hidden
#line 2 "/Users/Aelien/Documents/c#/BigProject/Views/_ViewImports.cshtml"
using BigProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ead8010f22eb08228032f54fde7f44139d6ab6", @"/Views/Big/One.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e974194ef140dff56203e4cfd70dc8d95934ac9", @"/Views/_ViewImports.cshtml")]
    public class Views_Big_One : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 95, true);
            WriteLiteral("<h2>Dojo Activity Center</h2>\n<a href=\"/Dashboard\">Home</a>\n<a href=\"/logout\">Log off</a><br>\n\n");
            EndContext();
#line 5 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
 if (@Model.Attendee.Count == 0) {

#line default
#line hidden
            BeginContext(130, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 136, "\"", 169, 2);
            WriteAttributeValue("", 143, "/joinact/", 143, 9, true);
#line 6 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
WriteAttributeValue("", 152, Model.ActivityId, 152, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(170, 10, true);
            WriteLiteral(">Join</a>\n");
            EndContext();
#line 7 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
}
else {

#line default
#line hidden
#line 9 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
 foreach (var y in @Model.Attendee) {

#line default
#line hidden
#line 10 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
 if (@y.UserId == @ViewBag.co.UserId)
{

#line default
#line hidden
            BeginContext(267, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 273, "\"", 307, 2);
            WriteAttributeValue("", 280, "/leaveact/", 280, 10, true);
#line 12 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
WriteAttributeValue("", 290, Model.ActivityId, 290, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(308, 11, true);
            WriteLiteral(">Leave</a>\n");
            EndContext();
#line 13 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
    break;
}
else
{

#line default
#line hidden
            BeginContext(339, 6, true);
            WriteLiteral("    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 345, "\"", 378, 2);
            WriteAttributeValue("", 352, "/joinact/", 352, 9, true);
#line 17 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
WriteAttributeValue("", 361, Model.ActivityId, 361, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(379, 10, true);
            WriteLiteral(">Join</a>\n");
            EndContext();
#line 18 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
}

#line default
#line hidden
#line 18 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
 
}

#line default
#line hidden
#line 19 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
 
}

#line default
#line hidden
            BeginContext(395, 24, true);
            WriteLiteral("\n<h3>Event Coordinator: ");
            EndContext();
            BeginContext(420, 20, false);
#line 22 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
                  Write(ViewBag.co.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(440, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(442, 19, false);
#line 22 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
                                        Write(ViewBag.co.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(461, 11, true);
            WriteLiteral("</h3>\n\n<h2>");
            EndContext();
            BeginContext(473, 16, false);
#line 24 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
Write(Model.MyActivity);

#line default
#line hidden
            EndContext();
            BeginContext(489, 31, true);
            WriteLiteral("</h2>\n\n<h3>Description</h3>\n<p>");
            EndContext();
            BeginContext(521, 17, false);
#line 27 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(538, 33, true);
            WriteLiteral("</p>\n\n<h3>Participants</h3>\n<ul>\n");
            EndContext();
#line 31 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
     foreach (var g in @Model.Attendee)
    {

#line default
#line hidden
            BeginContext(617, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(630, 16, false);
#line 33 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
       Write(g.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(646, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(648, 15, false);
#line 33 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
                         Write(g.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(663, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 34 "/Users/Aelien/Documents/c#/BigProject/Views/Big/One.cshtml"
    }

#line default
#line hidden
            BeginContext(675, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591