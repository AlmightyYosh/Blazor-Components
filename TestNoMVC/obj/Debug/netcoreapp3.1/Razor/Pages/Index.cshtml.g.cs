#pragma checksum "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8c0b8c31840f8e9e66a05b6a5e21183edcd59db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TestNoMVC.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace TestNoMVC.Pages
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
#line 1 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\_ViewImports.cshtml"
using TestNoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
using TestNoMVCModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
using TestNoMVC.WebSite.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8c0b8c31840f8e9e66a05b6a5e21183edcd59db", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d746e6064427f175740a95dcacb65bca35ad614", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <div id=\"myCarousel\" class=\"carousel slide\" data-ride=\"carousel\">\r\n");
#nullable restore
#line 15 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
         foreach (var product in ProductService.GetProducts())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ol class=\"carousel-indicators\">\r\n                <li data-target=\"#myCarousel\" data-slide-to=\"0\"");
            BeginWriteAttribute("class", " class=\"", 484, "\"", 492, 0);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n                <li data-target=\"#myCarousel\" data-slide-to=\"1\" class=\"active\"></li>\r\n                <li data-target=\"#myCarousel\" data-slide-to=\"2\"");
            BeginWriteAttribute("class", " class=\"", 650, "\"", 658, 0);
            EndWriteAttribute();
            WriteLiteral("></li>\r\n            </ol>\r\n");
            WriteLiteral("            <div class=\"carousel-inner\">\r\n\r\n");
#nullable restore
#line 28 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
                 if (product.Id == "1")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <img class=\"first-slide\"");
            BeginWriteAttribute("src", " src=\'", 895, "\'", 915, 1);
#nullable restore
#line 31 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
WriteAttributeValue("", 901, product.Image, 901, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""First slide"">
                        <div class=""container"">
                            <div class=""carousel-caption text-left"">
                                <h1>Example headline.</h1>
                                <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Sign up today</a></p>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 40 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 43 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
                 if (product.Id == "2")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item active\">\r\n\r\n\r\n\r\n\r\n                        <img class=\"second-slide\"");
            BeginWriteAttribute("src", " src=\'", 1729, "\'", 1749, 1);
#nullable restore
#line 50 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
WriteAttributeValue("", 1735, product.Image, 1735, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Second slide"">
                        <div class=""container"">
                            <div class=""carousel-caption"">
                                <h1>Another example headline.</h1>
                                <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Learn more</a></p>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 59 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 61 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
                 if (product.Id == "3")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"carousel-item\">\r\n                        <img class=\"third-slide\"");
            BeginWriteAttribute("src", " src=\'", 2541, "\'", 2561, 1);
#nullable restore
#line 64 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
WriteAttributeValue("", 2547, product.Image, 2547, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Third slide"">
                        <div class=""container"">
                            <div class=""carousel-caption text-right"">
                                <h1>One more for good measure.</h1>
                                <p>Cras justo odio, dapibus ac facilisis in, egestas eget quam. Donec id elit non mi porta gravida at eget metus. Nullam id dolor id nibh ultricies vehicula ut id elit.</p>
                                <p><a class=""btn btn-lg btn-primary"" href=""#"" role=""button"">Browse gallery</a></p>
                            </div>
                        </div>
                    </div>
");
#nullable restore
#line 73 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n");
            WriteLiteral(@"            <a class=""carousel-control-prev"" href=""#myCarousel"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#myCarousel"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
");
#nullable restore
#line 88 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n\r\n\r\n    \r\n\r\n<div class=\"row\" style=\"padding-top: 10px\">\r\n");
#nullable restore
#line 95 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
     foreach (var product in ProductService.GetProducts())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 97 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
         if (product.Id == "4")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3\">\r\n                <div class=\"card\" style=\"border: none;\">\r\n                    <img class=\"card-img\"");
            BeginWriteAttribute("src", " src=\"", 4077, "\"", 4097, 1);
#nullable restore
#line 101 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
WriteAttributeValue("", 4083, product.Image, 4083, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Generic placeholder image"" height=""200"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Card title</h5>
                        <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
                    </div>

                </div>
            </div><!-- /.col-lg-4 -->
");
#nullable restore
#line 110 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
         if (product.Id == "5")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3\">\r\n                <div class=\"card\" style=\"border: none;\">\r\n                    <img class=\"card-img\"");
            BeginWriteAttribute("src", " src=\"", 4763, "\"", 4783, 1);
#nullable restore
#line 116 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
WriteAttributeValue("", 4769, product.Image, 4769, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Generic placeholder image"" width=""140"" height=""200"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Card title</h5>
                        <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
                    </div>

                </div>
            </div><!-- /.col-lg-4 -->
");
#nullable restore
#line 125 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 127 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
         if (product.Id == "6")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3\">\r\n                <div class=\"card\" style=\"border: none;\">\r\n                    <img class=\"card-img\"");
            BeginWriteAttribute("src", " src=\"", 5461, "\"", 5481, 1);
#nullable restore
#line 131 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
WriteAttributeValue("", 5467, product.Image, 5467, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Generic placeholder image"" width=""140"" height=""200"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Card title</h5>
                        <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
                    </div>

                </div>
            </div><!-- /.col-lg-4 -->
");
#nullable restore
#line 140 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
         if (product.Id == "7")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-lg-3\">\r\n                <div class=\"card\" style=\"border: none;\">\r\n                    <img class=\"card-img\"");
            BeginWriteAttribute("src", " src=\"", 6159, "\"", 6179, 1);
#nullable restore
#line 146 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
WriteAttributeValue("", 6165, product.Image, 6165, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Generic placeholder image"" width=""140"" height=""200"">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Card title</h5>
                        <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                        <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
                    </div>

                </div>
            </div><!-- /.col-lg-4 -->
");
#nullable restore
#line 155 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 155 "C:\Users\yjwar\source\repos\BlazorNoMVC\BlazorNoMVC\Pages\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    \r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public JsonFileProductService ProductService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
