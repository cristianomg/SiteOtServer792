#pragma checksum "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d5a04acb21624d992f71bdf22b052afd8060082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ranking_Magic), @"mvc.1.0.view", @"/Views/Ranking/Magic.cshtml")]
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
#nullable restore
#line 1 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\_ViewImports.cshtml"
using OTServer.UI.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\_ViewImports.cshtml"
using OTServer.UI.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d5a04acb21624d992f71bdf22b052afd8060082", @"/Views/Ranking/Magic.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a48297989eac72e57a272471aa3c8fa07c0e9e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Ranking_Magic : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OTServer.UI.MVC.Models.RankMagicViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
  
    ViewData["Title"] = "Magic Level";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"col-6\">\r\n                ");
#nullable restore
#line 13 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"col-6\">\r\n                ");
#nullable restore
#line 16 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
           Write(Html.DisplayNameFor(model => model.Magic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
          
            int count = 0;
            foreach (var item in Model)
            {
                string estilo = count % 2 == 0 ? "background-color:#CFFCF0" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("style", " style=\"", 679, "\"", 694, 1);
#nullable restore
#line 27 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
WriteAttributeValue("", 687, estilo, 687, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td class=\"col-6\">\r\n                        <button class=\"btn btn-default details\" data-id=\"");
#nullable restore
#line 29 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"glyphicon glyphicon-file\"></i>");
#nullable restore
#line 29 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
                                                                                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                    </td>\r\n                    <td class=\"col-6\">\r\n                        ");
#nullable restore
#line 32 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Magic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
                count++;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<nav aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination justify-content-center\">\r\n        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1371, "\"", 1443, 1);
#nullable restore
#line 44 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
WriteAttributeValue("", 1378, Url.Action("Magic", "ranking", new { page = @ViewBag.page - 1 }), 1378, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a></li>\r\n        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1514, "\"", 1570, 1);
#nullable restore
#line 45 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
WriteAttributeValue("", 1521, Url.Action("Magic", "ranking", new { page = 1 }), 1521, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">1</a></li>\r\n        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1634, "\"", 1690, 1);
#nullable restore
#line 46 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
WriteAttributeValue("", 1641, Url.Action("Magic", "ranking", new { page = 2 }), 1641, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">2</a></li>\r\n        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1754, "\"", 1810, 1);
#nullable restore
#line 47 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
WriteAttributeValue("", 1761, Url.Action("Magic", "ranking", new { page = 3 }), 1761, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">3</a></li>\r\n        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 1874, "\"", 1946, 1);
#nullable restore
#line 48 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Magic.cshtml"
WriteAttributeValue("", 1881, Url.Action("Magic", "ranking", new { page = @ViewBag.page + 1 }), 1881, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Next</a></li>\r\n    </ul>\r\n</nav>\r\n<div class=\"modal fade\" id=\"modal\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalCenterTitle\" aria-hidden=\"true\">\r\n\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            $("".details"").click(function () {
                var id = $(this).attr(""data-id"");
                $(""#modal"").load(""Player/searchbyid?id="" + id, function () {
                    $(""#modal"").modal(""show"");
                })
            });
        })
    </script>
");
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OTServer.UI.MVC.Models.RankMagicViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
