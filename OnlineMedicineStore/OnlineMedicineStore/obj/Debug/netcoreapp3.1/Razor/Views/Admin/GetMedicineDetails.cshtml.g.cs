#pragma checksum "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71fd77f3c36c5c30a069099de8533099ad3a09d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GetMedicineDetails), @"mvc.1.0.view", @"/Views/Admin/GetMedicineDetails.cshtml")]
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
#line 1 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\_ViewImports.cshtml"
using OnlineMedicineStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71fd77f3c36c5c30a069099de8533099ad3a09d1", @"/Views/Admin/GetMedicineDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"391fa6e976a60afa56be1d9c34779fd3d90d85a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_GetMedicineDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineMedicineStore.Data.Medicine>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white;list-style:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
  
    ViewData["Title"] = "Medicine Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h3 class=\"display-4 h3 text-center\">Medicine details</h3>\r\n    <div class=\"card justify-content-center\" style=\"width: 18rem;margin-left:140px;\">\r\n          <img");
            BeginWriteAttribute("src", " src=\"", 1620, "\"", 1658, 3);
            WriteAttributeValue("", 1626, "/images/", 1626, 8, true);
#nullable restore
#line 54 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
WriteAttributeValue("", 1634, Model.MedicineName, 1634, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1653, ".jpg", 1654, 5, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"image\" style=\"width:100%;height:15vw;object-fit:cover;\">\r\n          <div class=\"card-title font-weight-bold text-center\"> ");
#nullable restore
#line 55 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
                                                           Write(Html.DisplayFor(model => model.MedicineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n          <ul class=\"list-group list-group-flush\">\r\n              <li class=\"list-group-item\">");
#nullable restore
#line 57 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.MedicineName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 57 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
                                                                                         Write(Html.DisplayFor(model => model.MedicineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n              <li class=\"list-group-item\">");
#nullable restore
#line 58 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 58 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
                                                                                     Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n              <li class=\"list-group-item\">");
#nullable restore
#line 59 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 59 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
                                                                                        Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n              <li class=\"list-group-item\">");
#nullable restore
#line 60 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 60 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
                                                                                  Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Rs.</li>\r\n              <li class=\"list-group-item\">Prescription Required : ");
#nullable restore
#line 61 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
                                                             Write(Html.DisplayFor(model => model.IsPrescriptionRequired));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n          </ul>\r\n          <div class=\"card-body\">\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71fd77f3c36c5c30a069099de8533099ad3a09d110500", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\vedant rajyaguru\Source\Repos\Online-Medicine-Store\OnlineMedicineStore\OnlineMedicineStore\Views\Admin\GetMedicineDetails.cshtml"
                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71fd77f3c36c5c30a069099de8533099ad3a09d112969", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n          </div>\r\n    </div>\r\n</div>\r\n\r\n   \r\n\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineMedicineStore.Data.Medicine> Html { get; private set; }
    }
}
#pragma warning restore 1591