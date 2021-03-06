#pragma checksum "D:\.net projects\PlaneLocation\PlaneLocation\Views\PlaneDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10ea844603d702a76962a3e838877795b258ecf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlaneDetails_Details), @"mvc.1.0.view", @"/Views/PlaneDetails/Details.cshtml")]
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
#line 1 "D:\.net projects\PlaneLocation\PlaneLocation\Views\_ViewImports.cshtml"
using PlaneLocation;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10ea844603d702a76962a3e838877795b258ecf2", @"/Views/PlaneDetails/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"663109b1bf22c27c37a427547fafbc89c132be9b", @"/Views/_ViewImports.cshtml")]
    public class Views_PlaneDetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

    <div>
        <h4>View Plane Details</h4>
        <hr />
        <div class=""row"">
            <div class=""col-md-8"">
                <dl class=""row"">
                    <dt class=""col-sm-2"">
                        Make
                    </dt>
                    <dd class=""col-sm-10"" data-bind=""text: Make"">

                    </dd>
                    <dt class=""col-sm-2"">
                        Model
                    </dt>
                    <dd class=""col-sm-10"" data-bind=""text: Model"">

                    </dd>
                    <dt class=""col-sm-2"">
                        Registration
                    </dt>
                    <dd class=""col-sm-10"" data-bind=""text: Registration"">

                    </dd>
                    <dt class=""col-sm-2"">
                        Location
                    </dt>
                    <dd class=""col-sm-10"" data-bind=""text: Location"">

                    </dd>
                    <dt class=""col-sm-2"">
      ");
            WriteLiteral(@"                  Date And Time
                    </dt>
                    <dd class=""col-sm-10"" data-bind=""text: DateAndTime"">

                    </dd>

                </dl>
            </div>
            <div class=""col-md-4"">
                <img width=""100px"" height=""100px"" data-bind=""attr:{src: imagePath}"" />
            </div>
        </div>
    </div>
<div>
");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10ea844603d702a76962a3e838877795b258ecf24725", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/knockout/3.5.1/knockout-latest.js"" integrity=""sha512-2AL/VEauKkZqQU9BHgnv48OhXcJPx9vdzxN1JrKDVc4FPU/MEE/BZ6d9l0mP7VmvLsjtYwqiYQpDskK9dG8KBA=="" crossorigin=""anonymous""></script>


    <script>
        $(document).ready(function () {
            var viewModel = {
             
            // Data
           };
       var url = window.location.href;
        var array = url.split('/');

        var planeId = array[array.length - 1];
        $.ajax({
            url: ""/api/Details/""+planeId,
            dataType: 'json'
        }).done(function (data) {
                 viewModel.Make= ko.observable(data.make),
                 viewModel.Model= ko.observable(data.model),
                 viewModel.Registration= ko.observable(data.registration),
                 viewModel.Location= ko.observable(data.location),
                 viewModel.DateAndTime= ko.observable(data.dateAndTime.replace('T', ' ')),
                 viewModel.imagePath");
                WriteLiteral(" = ko.observable(data.imagePath==\"\"?\"/images/default.jpg\":\"/images/\"+data.imagePath)\r\n            ko.applyBindings(viewModel);\r\n\r\n        }).error(function () {\r\n        });\r\n        });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
