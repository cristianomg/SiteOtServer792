#pragma checksum "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca695d4d306e6a32c0605cdfb95d8c0afae7212f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ranking_Index), @"mvc.1.0.view", @"/Views/Ranking/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca695d4d306e6a32c0605cdfb95d8c0afae7212f", @"/Views/Ranking/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a48297989eac72e57a272471aa3c8fa07c0e9e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Ranking_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OTServer.UI.MVC.Models.RankingLevelViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
  
    ViewData["Title"] = "Level";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Resets));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Voc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Exp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
          
            int count = 0;
            foreach (var item in Model)
            {
                string estilo = count % 2 == 0 ? "background-color:#CFFCF0" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("style", " style=\"", 938, "\"", 953, 1);
#nullable restore
#line 37 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
WriteAttributeValue("", 946, estilo, 946, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>\r\n                        <button class=\"btn btn-default details\" data-id=\"");
#nullable restore
#line 39 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
                                                                    Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"glyphicon glyphicon-file\"></i>");
#nullable restore
#line 39 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
                                                                                                                      Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 43 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Level));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 46 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Resets));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 49 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
                          
                            string result = "";
                            var voc = item.Voc;
                            switch (voc)
                            {
                                case "1":
                                    result = "S";
                                    break;
                                case "2":
                                    result = "D";
                                    break;
                                case "3":
                                    result = "A";
                                    break;
                                case "4":
                                    result = "K";
                                    break;
                                case "5":
                                    result = "MS";
                                    break;
                                case "6":
                                    result = "ED";
                                    break;
                                case "7":
                                    result = "RA";
                                    break;
                                case "8":
                                    result = "EK";
                                    break;
                                case "9":
                                    result = "W";
                                    break;
                                case "10":
                                    result = "C";
                                    break;
                                case "11":
                                    result = "R";
                                    break;
                                case "12":
                                    result = "SL";
                                    break;
                                case "13":
                                    result = "DW";
                                    break;
                                case "14":
                                    result = "EC";
                                    break;
                                case "15":
                                    result = "ER";
                                    break;
                                case "16":
                                    result = "DSL";
                                    break;
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 104 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
                   Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 107 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Exp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 112 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
                count++;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<nav aria-label=\"Page navigation example\">\r\n    <ul class=\"pagination justify-content-center\">\r\n        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4411, "\"", 4483, 1);
#nullable restore
#line 119 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
WriteAttributeValue("", 4418, Url.Action("index", "ranking", new { page = @ViewBag.page - 1 }), 4418, 65, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Previous</a></li>\r\n        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4554, "\"", 4610, 1);
#nullable restore
#line 120 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
WriteAttributeValue("", 4561, Url.Action("index", "ranking", new { page = 1 }), 4561, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">1</a></li>\r\n        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4674, "\"", 4730, 1);
#nullable restore
#line 121 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
WriteAttributeValue("", 4681, Url.Action("index", "ranking", new { page = 2 }), 4681, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">2</a></li>\r\n        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4794, "\"", 4850, 1);
#nullable restore
#line 122 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
WriteAttributeValue("", 4801, Url.Action("index", "ranking", new { page = 3 }), 4801, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">3</a></li>\r\n        <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4914, "\"", 4986, 1);
#nullable restore
#line 123 "D:\Area de trabalho\CSharp\server\OTServer.UI.MVC\OTServer.UI.MVC\Views\Ranking\Index.cshtml"
WriteAttributeValue("", 4921, Url.Action("index", "ranking", new { page = @ViewBag.page + 1 }), 4921, 65, false);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OTServer.UI.MVC.Models.RankingLevelViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
