#pragma checksum "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aea2f8c46c2d0e3826b21f79bbee9ab2cc98228a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_QandA_Detail), @"mvc.1.0.view", @"/Views/QandA/Detail.cshtml")]
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
#line 1 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\_ViewImports.cshtml"
using DapperOverflow;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\_ViewImports.cshtml"
using DapperOverflow.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aea2f8c46c2d0e3826b21f79bbee9ab2cc98228a", @"/Views/QandA/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14bd00d17f4bd890ab5f401ea4a830e86779818e", @"/Views/_ViewImports.cshtml")]
    public class Views_QandA_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Question>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p><b>Logged in as: ");
#nullable restore
#line 2 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
               Write(ViewBag.activeUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n<style>\r\n    p.groove {\r\n        border-style: groove;\r\n    }\r\n</style>\r\n");
#nullable restore
#line 8 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
  
    int status = Model.Status;
    string message = "";
    switch (status)
    {
        case 0:
            message = "OPEN";
            break;
        case 1:
            message = "CLOSED";
            break;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"/QandA/Index\">Back to Questions</a>\r\n<h1>");
#nullable restore
#line 22 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 22 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
              Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h6><i>");
#nullable restore
#line 23 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
  Write(Model.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i> by: ");
#nullable restore
#line 23 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
                        Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<br />\r\n<p class=\"groove\">");
#nullable restore
#line 25 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
             Write(Model.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<br />\r\n");
#nullable restore
#line 27 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
 if (Model.Status != 1 && Model.Username == ViewBag.activeUser)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 640, "\"", 691, 3);
            WriteAttributeValue("", 650, "location.href=\'/QandA/Edit?_id=", 650, 31, true);
#nullable restore
#line 29 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 681, Model.id, 681, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 690, "\'", 690, 1, true);
            EndWriteAttribute();
            WriteLiteral(">EDIT</button>\r\n    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 719, "\"", 772, 3);
            WriteAttributeValue("", 729, "location.href=\'/QandA/Delete?_id=", 729, 33, true);
#nullable restore
#line 30 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 762, Model.id, 762, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 771, "\'", 771, 1, true);
            EndWriteAttribute();
            WriteLiteral(">DELETE</button>\r\n");
#nullable restore
#line 31 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n");
#nullable restore
#line 34 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
 if (ViewBag.Answerlist.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Answers</h4>\r\n");
#nullable restore
#line 37 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
    foreach (Answer answer in ViewBag.Answerlist)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n    <i>");
#nullable restore
#line 40 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
  Write(answer.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - by: ");
#nullable restore
#line 40 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
                       Write(answer.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </i>\r\n");
#nullable restore
#line 41 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
     if (answer.Username == ViewBag.activeUser && @Model.Status != 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 1073, "\"", 1111, 2);
            WriteAttributeValue("", 1080, "/QandA/GetAnswer?_id=", 1080, 21, true);
#nullable restore
#line 43 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 1101, answer.id, 1101, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>EDIT</b></a>\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1140, "\"", 1178, 2);
            WriteAttributeValue("", 1147, "/QandA/DelAnswer?_id=", 1147, 21, true);
#nullable restore
#line 44 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 1168, answer.id, 1168, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><b>DELETE</b></a>\r\n");
#nullable restore
#line 45 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"groove\">");
#nullable restore
#line 47 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
                     Write(answer.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 48 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 51 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
 if (@Model.Status != 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1316, "\"", 1372, 3);
            WriteAttributeValue("", 1326, "location.href=\'/QandA/AddAnswer?_id=", 1326, 36, true);
#nullable restore
#line 53 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 1362, Model.id, 1362, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1371, "\'", 1371, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add an Answer</button>\r\n");
#nullable restore
#line 54 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
    if (Model.Username == ViewBag.activeUser)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button");
            BeginWriteAttribute("onclick", " onclick=\"", 1467, "\"", 1528, 3);
            WriteAttributeValue("", 1477, "location.href=\'/QandA/Close?_id=", 1477, 32, true);
#nullable restore
#line 56 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
WriteAttributeValue("", 1509, Model.id, 1509, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1518, "&status=1\'", 1518, 10, true);
            EndWriteAttribute();
            WriteLiteral(">Mark as Resolved</button>\r\n");
#nullable restore
#line 57 "C:\devbuild4\DapperOverflow\DapperOverflow\Views\QandA\Detail.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
