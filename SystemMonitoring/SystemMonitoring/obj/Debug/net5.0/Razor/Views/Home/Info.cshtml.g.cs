#pragma checksum "C:\Users\chase\Source\Repos\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a77284be0f38cad8c5daa05f1102e0a3b108ddb9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Info), @"mvc.1.0.view", @"/Views/Home/Info.cshtml")]
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
#line 1 "C:\Users\chase\Source\Repos\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\_ViewImports.cshtml"
using SystemMonitoring;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\chase\Source\Repos\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\_ViewImports.cshtml"
using SystemMonitoring.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77284be0f38cad8c5daa05f1102e0a3b108ddb9", @"/Views/Home/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"154a556c6993cd4ab2cd1d685cecaf1e22c21dfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SystemMonitoring.ViewModels.HistoryViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\chase\Source\Repos\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Info.cshtml"
  
	ViewData["Title"] = "Task Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link rel=\"stylesheet\" type=\"text/css\" href=\"https://cdn.datatables.net/1.10.24/css/jquery.dataTables.css\">\r\n\r\n<h1>");
#nullable restore
#line 8 "C:\Users\chase\Source\Repos\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Info.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div id=""info"">
	
</div>

<h1>Run History</h1>
<div style=""border: 1px solid black; padding: 10px;"">
	<table id=""history_table"" class=""display"">
		<thead>
			<tr>
				<th>ID</th>
				<th>Status</th>
				<th>Time ran</th>
			</tr>
		</thead>
		<tbody id=""history_body"">
");
#nullable restore
#line 25 "C:\Users\chase\Source\Repos\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Info.cshtml"
             foreach (var run in Model.JobHistories)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 28 "C:\Users\chase\Source\Repos\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Info.cshtml"
                   Write(run.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 29 "C:\Users\chase\Source\Repos\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Info.cshtml"
                   Write(run.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td>");
#nullable restore
#line 30 "C:\Users\chase\Source\Repos\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Info.cshtml"
                   Write(run.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 32 "C:\Users\chase\Source\Repos\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Info.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n\t<span id=\"error\"></span>\r\n</div>\r\n\r\n<script>\r\n\t$(document).ready(function (e) {\r\n\r\n\t\tvar id = ");
#nullable restore
#line 41 "C:\Users\chase\Source\Repos\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Info.cshtml"
            Write(Model.JobHistories.FirstOrDefault().ReoccurringJobId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

		$.ajax({
			type: ""GET"",
			url: ""/Home/TaskInfo"",
			data: { taskId: id },
			success: function (data) {
				$(""#info"").html(data);
			},
			error: function () {
				$(""#info"").html(""Could not find the information for this task"");
			}
		});
	});
</script>

<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.24/js/jquery.dataTables.js""></script>

<script>
	$(document).ready(function () {
		$('#history_table').DataTable();
	});
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SystemMonitoring.ViewModels.HistoryViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
