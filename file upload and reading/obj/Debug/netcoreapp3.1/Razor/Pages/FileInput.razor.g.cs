#pragma checksum "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b7e97080c12b693f8cc35674a5287db5a6a8ae"
// <auto-generated/>
#pragma warning disable 1591
namespace file_upload_and_reading.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\_Imports.razor"
using file_upload_and_reading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\_Imports.razor"
using file_upload_and_reading.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
using file_upload_and_reading.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
using file_upload_and_reading.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FileInput")]
    public partial class FileInput : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FileInput</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "display:flex");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "style", "margin:10px");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(7);
            __builder.AddAttribute(8, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 11 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                             HandleFileSelected

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n\r\n        \r\n");
#nullable restore
#line 15 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
         if (students == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.AddMarkupContent(11, "<p>loading.........:v</p>\r\n");
#nullable restore
#line 18 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "cellpadding", "0");
            __builder.AddAttribute(14, "cellspacing", "0");
            __builder.AddAttribute(15, "border", "1");
            __builder.AddMarkupContent(16, "\r\n\r\n");
#nullable restore
#line 22 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                 foreach (Students student in students)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                    ");
            __builder.OpenElement(18, "tr");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, "Name:");
            __builder.AddContent(22, 
#nullable restore
#line 25 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                                  student.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, "Role:");
            __builder.AddContent(26, 
#nullable restore
#line 26 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                                  student.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, "Email:");
            __builder.AddContent(30, 
#nullable restore
#line 27 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                                   student.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 29 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(33, "            ");
            __builder.CloseElement();
#nullable restore
#line 30 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(34, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "style", "margin:10px");
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenComponent<BlazorInputFile.InputFile>(39);
            __builder.AddAttribute(40, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorInputFile.IFileListEntry[]>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorInputFile.IFileListEntry[]>(this, 
#nullable restore
#line 33 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                             HandleFileSelected2

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n\r\n        \r\n");
#nullable restore
#line 37 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
         if (students == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, "            ");
            __builder.AddMarkupContent(43, "<p>loading.........:v</p>\r\n");
#nullable restore
#line 40 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "table");
            __builder.AddAttribute(45, "cellpadding", "0");
            __builder.AddAttribute(46, "cellspacing", "0");
            __builder.AddAttribute(47, "border", "1");
            __builder.AddMarkupContent(48, "\r\n\r\n");
#nullable restore
#line 44 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                 foreach (Students2 student in students2)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(49, "                    ");
            __builder.OpenElement(50, "tr");
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, "Name:");
            __builder.AddContent(54, 
#nullable restore
#line 47 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                                  student.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, "Role:");
            __builder.AddContent(58, 
#nullable restore
#line 48 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                                  student.Role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "td");
            __builder.AddContent(61, "Email:");
            __builder.AddContent(62, 
#nullable restore
#line 49 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                                   student.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n");
#nullable restore
#line 51 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(65, "            ");
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(66, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n");
            __builder.OpenElement(69, "button");
            __builder.AddAttribute(70, "class", "btn btn-primary");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
                                          GenerateExcel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(72, " GenerateExcel ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\chova\source\repos\file upload and reading\file upload and reading\Pages\FileInput.razor"
       
    public List<Students> students = new List<Students>();
    public List<Students2> students2 = new List<Students2>();
    IFileListEntry file;
    async Task HandleFileSelected(IFileListEntry[] files)
    {
        file = files.FirstOrDefault();
        if (file != null)
        {
            await fileUpload.UploadAsync(file);
            students = fileUpload.GetStudents();
        }
    }
    IFileListEntry file2;
    async Task HandleFileSelected2(IFileListEntry[] files)
    {
        file2 = files.FirstOrDefault();
        if (file != null)
        {
            await fileUpload.UploadAsync2(file2);
            students2 = fileUpload.GetStudents2s();
        }
    }
    //protected void ShowExcel()
    //{
    //    students = fileUpload.GetStudents();

    //}
    //protected void ShowExcel2()
    //{
    //    students2 = fileUpload.GetStudents2s();

    //}
    private void GenerateExcel()
    {
        
        fileUpload.GenerateExcel(iJSRuntime);
    }
    //protected override void OnInitialized()
    //{
    //    ShowExcel();
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime iJSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload fileUpload { get; set; }
    }
}
#pragma warning restore 1591