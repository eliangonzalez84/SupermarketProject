#pragma checksum "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "720f02e6bcd821d2869b4f00ab13c475ae74b36c"
// <auto-generated/>
#pragma warning disable 1591
namespace SupermarketProject.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using SupermarketProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using SupermarketProject.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using SupermarketProject.Controls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\_Imports.razor"
using CoreBusiness;

#line default
#line hidden
#nullable disable
    public partial class SelectProductForSellingComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "<label for=\"category\">Categoria</label>\r\n    ");
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "id", "category");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 6 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
                                 SelectedCategoryId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SelectedCategoryId = __value, SelectedCategoryId));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "selected");
            __builder.CloseElement();
#nullable restore
#line 8 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
         foreach (var cat in categories)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 10 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
                            cat.CategoryId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 10 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
                                             cat.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 15 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
 if (productsInCategory != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.AddMarkupContent(15, "<thead><tr><th>Nombre Producto</th>\r\n                <th>Cantidad existente</th></tr></thead>\r\n        ");
            __builder.OpenElement(16, "tbody");
#nullable restore
#line 25 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
             foreach (var prod in productsInCategory)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "tr");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
                              (() => OnSelectProduct(prod))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "style", 
#nullable restore
#line 28 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
                             prod.ProductId == selectedProductId ? "background-color: beige; cursor:pointer;" : "cursor:pointer"

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 30 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
                         prod.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 32 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
                         prod.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Controls\SelectProductForSellingComponent.razor"
       
    private IEnumerable<Product> productsInCategory;
    private int selectedProductId;
    [Parameter]
    public EventCallback<Product> OnProductSelected { get; set; }

    private int selectedCategoryId;
    private int SelectedCategoryId
    {
        get { return selectedCategoryId; }
        set
        {
            selectedCategoryId = value;
            productsInCategory = viewProductByCategoryId.Execute(value);
            StateHasChanged();
        }
    }
    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        categories = viewCategoriesUseCase.Execute();
    }

    private void OnSelectProduct(Product product)
    {
        selectedCategoryId = product.ProductId;
        OnProductSelected.InvokeAsync(product);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IViewProductByCategoryId viewProductByCategoryId { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IViewCategoriesUseCase viewCategoriesUseCase { get; set; }
    }
}
#pragma warning restore 1591