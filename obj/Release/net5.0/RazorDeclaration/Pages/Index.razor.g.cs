// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace P2Webasm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using P2Webasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using P2Webasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using P2Webasm.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using P2Webasm.Misc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\_Imports.razor"
using P2Webasm.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Index.razor"
       
    List<Product> product;

    protected override async Task OnInitializedAsync()
    {
        product = db.Get();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDatabase db { get; set; }
    }
}
#pragma warning restore 1591
