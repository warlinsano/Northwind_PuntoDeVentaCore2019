#pragma checksum "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "765f53fbdeec970dbe0dc59571948912d59e0670"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Details), @"mvc.1.0.view", @"/Views/Employees/Details.cshtml")]
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
#line 1 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\_ViewImports.cshtml"
using Northwind_PuntoDeVentaCore2019;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\_ViewImports.cshtml"
using Northwind_PuntoDeVentaCore2019.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"765f53fbdeec970dbe0dc59571948912d59e0670", @"/Views/Employees/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0486881e1309636e91e61f1c06379210ccdf3c08", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Northwind_PuntoDeVentaCore2019.Models.Employees>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-profile rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/no-profile.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n\n<h1>Details</h1>\n\n<div>\n    <h4>Employees</h4>\n    <hr />\n    <dl class=\"row\">\n\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 132 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n\n");
#nullable restore
#line 136 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
             if (String.IsNullOrEmpty(Model.PhotoBase64))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "765f53fbdeec970dbe0dc59571948912d59e06707340", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 139 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img id=\"img\" class=\"img-profile rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 4784, "\"", 4808, 1);
#nullable restore
#line 142 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
WriteAttributeValue("", 4790, Model.PhotoBase64, 4790, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200\" />\n");
#nullable restore
#line 143 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 148 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 151 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 154 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 157 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 160 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 163 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 166 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TitleOfCourtesy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 169 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.TitleOfCourtesy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 172 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 175 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 178 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 181 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 184 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 187 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 190 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 193 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 196 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 199 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 202 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 205 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 208 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 211 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 214 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 217 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.HomePhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 220 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Extension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 223 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Extension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 227 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 230 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 233 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PhotoPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 236 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.PhotoPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 239 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReportsToNavigation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 242 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReportsToNavigation.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "765f53fbdeec970dbe0dc59571948912d59e067021519", async() => {
                WriteLiteral("\n        Edit\n        <span aria-hidden=\"true\" class=\"fa fa-pencil-alt fa-fw\"></span>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 247 "C:\Users\Fanny-pc\Documents\REPOSITORIO\Northwind_PuntoDeVentaCore2019\Northwind_PuntoDeVentaCore2019\Views\Employees\Details.cshtml"
                                                   WriteLiteral(Model.EmployeeId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "765f53fbdeec970dbe0dc59571948912d59e067023922", async() => {
                WriteLiteral("\n        Back to List\n        <span aria-hidden=\"true\" class=\"fa fa-share\"></span>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Northwind_PuntoDeVentaCore2019.Models.Employees> Html { get; private set; }
    }
}
#pragma warning restore 1591
