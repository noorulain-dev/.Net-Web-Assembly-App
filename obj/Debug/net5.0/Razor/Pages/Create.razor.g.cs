#pragma checksum "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bca4781b1ed3ac028df3f6e93783c4069769bb1c"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 5 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
using System.Drawing;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/create/{id:guid}")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Create a product</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
                 createForm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
                                       OnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "<label>Name</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(6);
                __builder2.AddAttribute(7, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
                            createForm.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createForm.Name = __value, createForm.Name))));
                __builder2.AddAttribute(9, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => createForm.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n    ");
                __builder2.AddMarkupContent(11, "<label>Desc</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
                            createForm.Desc

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createForm.Desc = __value, createForm.Desc))));
                __builder2.AddAttribute(15, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => createForm.Desc));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n\r\n    ");
                __builder2.AddMarkupContent(17, "<label>Colour</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
                            createForm.Colour

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createForm.Colour = __value, createForm.Colour))));
                __builder2.AddAttribute(21, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => createForm.Colour));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n\r\n    ");
                __builder2.AddMarkupContent(23, "<label>Price</label>\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
                            createForm.PriceStr

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => createForm.PriceStr = __value, createForm.PriceStr))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => createForm.PriceStr));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenElement(29, "p");
#nullable restore
#line 25 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
     if (id != Guid.Empty)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(30, "img");
                __builder2.AddAttribute(31, "src", "data:image/png;base64," + " " + (
#nullable restore
#line 27 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
                                          loadedProduct.Image

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "height", "80");
                __builder2.CloseElement();
#nullable restore
#line 28 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(33);
                __builder2.AddAttribute(34, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
                         OnFileUpload

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.AddMarkupContent(36, "<button type=\"submit\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\noor_\OneDrive\Desktop\P2\webassembly\P2Webasm\Pages\Create.razor"
      

    private Product loadedProduct = new Product();

    class CreateForm
    {
        public String Name { get; set; }
        public String Colour { get; set; }
        public String Desc { get; set; }
        public String PriceStr { get; set; }
        public String ImgBase64 { get; set; }
        public String Image { get; set; }

    }


    [Parameter]
    public Guid id { get; set; }

    private CreateForm createForm = new CreateForm();

    async void OnFileUpload(InputFileChangeEventArgs arg)
    {
        using (var input = arg.File.OpenReadStream())
        {
            var buffer = new Byte[input.Length];

            await input.ReadAsync(buffer, 0, buffer.Length);

            createForm.ImgBase64 = Convert.ToBase64String(buffer);
        }
    }

    protected override void OnParametersSet()
    {
        db.Initialise();
        if (id != Guid.Empty)
        {
            Product p = db.GetOne(id);
            loadedProduct = p;
            createForm.Name = p.Name;
            createForm.Desc = p.Desc;
            createForm.Colour = p.Colour;
            createForm.ImgBase64 = p.Image;
            createForm.PriceStr = p.Price.ToString();
        }

    }


    void OnSubmit()
    {

        if (id != Guid.Empty)
        {
            var newProduct = new Product
            {
                Id = id,
                Name = createForm.Name,
                Desc = createForm.Desc,
                Colour = createForm.Colour,
                Price = double.Parse(createForm.PriceStr),
                Image = createForm.ImgBase64

            };

            loadedProduct = newProduct;
            db.Update(newProduct);
        }
        else
        {
            var newProduct = new Product
            {
                Id = Guid.NewGuid(),
                Name = createForm.Name,
                Desc = createForm.Desc,
                Colour = createForm.Colour,
                Image = createForm.ImgBase64,
                Price = double.Parse(createForm.PriceStr)
            };
            db.Insert(newProduct);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager mynav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDatabase db { get; set; }
    }
}
#pragma warning restore 1591
