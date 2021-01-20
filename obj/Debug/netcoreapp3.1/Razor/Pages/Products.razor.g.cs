#pragma checksum "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e93ea40e08d3de8d28858c2291e43f3d4955c060"
// <auto-generated/>
#pragma warning disable 1591
namespace CrudAppBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\_Imports.razor"
using CrudAppBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\_Imports.razor"
using CrudAppBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
using CrudAppBlazor.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/products")]
    public partial class Products : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "class", "nav-link");
            __builder.AddAttribute(2, "href", "AddProduct");
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Add New\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.AddMarkupContent(6, "<h1>Product Info</h1>\r\n");
#nullable restore
#line 10 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
 if (ListProduct == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "    ");
            __builder.AddMarkupContent(8, "<p><em> Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "    ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.AddMarkupContent(13, "<thead>\r\n            <tr>\r\n                <th>Product ID</th>\r\n                <th>Name</th>\r\n                <th>Category</th>\r\n                <th>Unit Price</th>\r\n                <th>Operation</th>\r\n            </tr>\r\n        </thead>\r\n\r\n        ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 28 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
             foreach (var item in ListProduct)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 31 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
                         item.ProductId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 32 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
                         item.ProductName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 33 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
                         item.ProductCategory

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 34 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
                         item.UnitPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "td");
            __builder.AddMarkupContent(32, "\r\n                        ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "class", "nav-link");
            __builder.AddAttribute(35, "href", "EditProduct/" + (
#nullable restore
#line 36 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
                                                               item.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.AddMarkupContent(37, "<span aria-hidden=\"true\"> </span>Edit\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "a");
            __builder.AddAttribute(40, "class", "nav-link");
            __builder.AddAttribute(41, "href", "DeleteProduct/" + (
#nullable restore
#line 39 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
                                                                 item.ProductId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.AddMarkupContent(43, "<span aria-hidden=\"true\"> </span>Delete\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 44 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 47 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\YY34\source\repos\CrudAppBlazor\CrudAppBlazor\Pages\Products.razor"
       

    List<ProductInfo> ListProduct;
    protected override async Task OnInitializedAsync()
    {
        ListProduct = await Task.Run(() => proservice.GetProducts());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProductService proservice { get; set; }
    }
}
#pragma warning restore 1591
