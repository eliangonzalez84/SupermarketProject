// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SupermarketProject.Pages
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
using CoreBusiness;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addproduct")]
    public partial class AddProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "F:\Users\User\Documents\VisualStudio\Supermercado\SupermarketManagement\SupermarketProject\Pages\AddProductComponent.razor"
       
    private Product product;
    private IEnumerable<Category> categories;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        product = new Product();
        categories = viewCategoriesUseCase.Execute();
    }

    private void OnValidSubmit()
    {
        addproductUseCase.Execute(product);
        navigationManager.NavigateTo("/products");
    }

    private void OnCancel()
    {
        navigationManager.NavigateTo("/products");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IViewCategoriesUseCase viewCategoriesUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IGetCategoryByIdUseCase getCategoryByIdUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UseCases.IAddProductUseCase addproductUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
