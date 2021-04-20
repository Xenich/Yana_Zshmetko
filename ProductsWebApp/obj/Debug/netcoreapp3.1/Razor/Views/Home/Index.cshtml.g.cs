#pragma checksum "D:\Projects\GoogleDrive\Programming\C#\ASPNet\Vakansia_Yana_Zshmetko\ProductsWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c1504c467ea01ad2e8902ae43f444ee786cfd08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\Vakansia_Yana_Zshmetko\ProductsWebApp\Views\_ViewImports.cshtml"
using ProductsWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\Vakansia_Yana_Zshmetko\ProductsWebApp\Views\_ViewImports.cshtml"
using ProductsWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c1504c467ea01ad2e8902ae43f444ee786cfd08", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a3c57b1918428cf8cd86df038ffb46ed966e7c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\Vakansia_Yana_Zshmetko\ProductsWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""text-center"">

        <h1 class=""display-4"">Products</h1>
        <button id=""btn_modal_window"">Добавить продукт</button>
        <div id=""my_modal"" class=""modal"">
            <div class=""modal_content"">
                <span class=""close_modal_window"">×</span>
                <p>Добавить</p>
                <div class=""row"">
                    <div class=""col-md-4"">
                        ");
#nullable restore
#line 17 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\Vakansia_Yana_Zshmetko\ProductsWebApp\Views\Home\Index.cshtml"
                   Write(Html.Label("Наименование"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                    <div class=""col-md-4"">
                        <input id=""productName"">
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-4"">
                        ");
#nullable restore
#line 25 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\Vakansia_Yana_Zshmetko\ProductsWebApp\Views\Home\Index.cshtml"
                   Write(Html.Label("Выберите категорию"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        ");
#nullable restore
#line 28 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\Vakansia_Yana_Zshmetko\ProductsWebApp\Views\Home\Index.cshtml"
                   Write(Html.DropDownList("categoryFilterItem", Model.Filter, new { @id = "categoryFilterItemModal" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-12"">
                        <input type=""button"" value=""ДОБАВИТЬ"" onclick=""AddProduct()"">
                    </div>
                </div>
            </div>
        </div>
        <hr />

        <div class=""row"">
            <div class=""col-md-4"">
                ");
#nullable restore
#line 42 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\Vakansia_Yana_Zshmetko\ProductsWebApp\Views\Home\Index.cshtml"
           Write(Html.DropDownList("categoryFilterItem", Model.Filter, "Фильтр по категории", new { @onchange = "ChangeCategoryFilterItem(this.selectedOptions[0].value)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-8\">\r\n                ");
#nullable restore
#line 45 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\Vakansia_Yana_Zshmetko\ProductsWebApp\Views\Home\Index.cshtml"
           Write(Html.Label("Количество элементов на странице:"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 46 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\Vakansia_Yana_Zshmetko\ProductsWebApp\Views\Home\Index.cshtml"
           Write(Html.DropDownList("ItemsCountOnPageFilterItem", Model.ItemsCountOnPage, new { @onchange = "ChangeItemsCount(this.selectedOptions[0].value)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n                <div id=\"ProductsTable\">\r\n                    ");
#nullable restore
#line 50 "D:\Projects\GoogleDrive\Programming\C#\ASPNet\Vakansia_Yana_Zshmetko\ProductsWebApp\Views\Home\Index.cshtml"
               Write(Html.Partial("ProductsTableView", Model.ProductsTable));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>





        <style>
            .modal {
                display: none;
                position: fixed;
                z-index: 1;
                left: 0;
                top: 0;
                width: 100%;
                height: 100%;
                overflow: auto;
                background-color: rgba(0,0,0,0.6);
                z-index: 1000;
            }

                .modal .modal_content {
                    background-color: #fefefe;
                    margin: 15% auto;
                    padding: 20px;
                    border: 1px solid #888;
                    width: 80%;
                    z-index: 99999;
                }

                    .modal .modal_content .close_modal_window {
                        color: #aaa;
                        float: right;
                        font-size: 28px;
                        font-weight: bold;
                        cursor: pointer;
                  ");
            WriteLiteral("  }\r\n        </style>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
