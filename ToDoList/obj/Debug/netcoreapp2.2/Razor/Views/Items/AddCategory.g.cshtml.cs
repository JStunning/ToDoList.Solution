#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\ToDoList.Solution\ToDoList\Views\Items\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8611c91fbe1fc8aa3baf4867a3f9b4c85ddda96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_AddCategory), @"mvc.1.0.view", @"/Views/Items/AddCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/AddCategory.cshtml", typeof(AspNetCore.Views_Items_AddCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8611c91fbe1fc8aa3baf4867a3f9b4c85ddda96", @"/Views/Items/AddCategory.cshtml")]
    public class Views_Items_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.Models.Item>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\ToDoList.Solution\ToDoList\Views\Items\AddCategory.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(61, 62, true);
            WriteLiteral("\r\n<h2>Add a category</h2>\r\n\r\n<h4>Add a category to this task: ");
            EndContext();
            BeginContext(124, 43, false);
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\ToDoList.Solution\ToDoList\Views\Items\AddCategory.cshtml"
                            Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(167, 9, true);
            WriteLiteral("</h4>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\ToDoList.Solution\ToDoList\Views\Items\AddCategory.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(211, 37, false);
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\ToDoList.Solution\ToDoList\Views\Items\AddCategory.cshtml"
Write(Html.HiddenFor(model => model.ItemId));

#line default
#line hidden
            EndContext();
            BeginContext(257, 29, false);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\ToDoList.Solution\ToDoList\Views\Items\AddCategory.cshtml"
Write(Html.Label("Select category"));

#line default
#line hidden
            EndContext();
            BeginContext(293, 31, false);
#line 16 "C:\Users\Stunning\Desktop\epicodusProjects\c#\ToDoList.Solution\ToDoList\Views\Items\AddCategory.cshtml"
Write(Html.DropDownList("CategoryId"));

#line default
#line hidden
            EndContext();
            BeginContext(328, 42, true);
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\r\n");
            EndContext();
#line 19 "C:\Users\Stunning\Desktop\epicodusProjects\c#\ToDoList.Solution\ToDoList\Views\Items\AddCategory.cshtml"
}

#line default
#line hidden
            BeginContext(373, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(379, 40, false);
#line 21 "C:\Users\Stunning\Desktop\epicodusProjects\c#\ToDoList.Solution\ToDoList\Views\Items\AddCategory.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(419, 6, true);
            WriteLiteral("</p>p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.Models.Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
