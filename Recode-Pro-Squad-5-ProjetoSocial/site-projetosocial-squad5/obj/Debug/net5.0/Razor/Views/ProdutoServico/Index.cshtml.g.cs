#pragma checksum "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\ProdutoServico\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e468fb4ff8b6c01e67e1628432007afcfc7097e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProdutoServico_Index), @"mvc.1.0.view", @"/Views/ProdutoServico/Index.cshtml")]
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
#line 1 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\_ViewImports.cshtml"
using site_projetosocial_squad5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\_ViewImports.cshtml"
using site_projetosocial_squad5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e468fb4ff8b6c01e67e1628432007afcfc7097e0", @"/Views/ProdutoServico/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115b1615ce6a7e84a90aae513a43b3313cacd377", @"/Views/_ViewImports.cshtml")]
    public class Views_ProdutoServico_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<site_projetosocial_squad5.Models.ProdutoServico>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contatar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Autonoma", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\ProdutoServico\Index.cshtml"
  
    ViewData["Title"] = "EmpoDelas - Produtos e Serviços";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<style>
        .teste{
            display: flex;
            flex-wrap: wrap;
        }
        section{
            margin: 1%;
        }
    </style>


<main class=""container"">
    
          <div><h1>Produtos e Serviços</h1></div>                  
                
<section class=""teste"">
");
#nullable restore
#line 26 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\ProdutoServico\Index.cshtml"
 foreach (var item in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card\" style=\"width: 18rem;\">\r\n    <div class=\"card-body\">\r\n    <h5 class=\"card-title\">");
#nullable restore
#line 29 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\ProdutoServico\Index.cshtml"
                      Write(item.nome_produtoServico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 30 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\ProdutoServico\Index.cshtml"
                                         Write(item.nomeNegocio_autonoma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    <p class=\"card-text\">");
#nullable restore
#line 31 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\ProdutoServico\Index.cshtml"
                    Write(item.descricao_produtoServico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p class=\"card-text\">");
#nullable restore
#line 32 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\ProdutoServico\Index.cshtml"
                    Write(item.preco_produtoServico);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e468fb4ff8b6c01e67e1628432007afcfc7097e07090", async() => {
                WriteLiteral("Ver Mais\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\ProdutoServico\Index.cshtml"
                              WriteLiteral(item.id_produtoServico);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e468fb4ff8b6c01e67e1628432007afcfc7097e09363", async() => {
                WriteLiteral("Contatar\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\ProdutoServico\Index.cshtml"
                                                         WriteLiteral(item.FK_id_autonoma);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <a href=\"https://forms.gle/TYqWfbTQcKdGdQcN6\" target=\"_blank\">Afiliar-Se\r\n    </a>\r\n  </div>\r\n</div>\r\n");
#nullable restore
#line 41 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\ProdutoServico\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<site_projetosocial_squad5.Models.ProdutoServico>> Html { get; private set; }
    }
}
#pragma warning restore 1591
