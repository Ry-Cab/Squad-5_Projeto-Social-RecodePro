#pragma checksum "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\Autonoma\Contatar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d219e804cc05149358e4abea729fd1badda9622"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autonoma_Contatar), @"mvc.1.0.view", @"/Views/Autonoma/Contatar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d219e804cc05149358e4abea729fd1badda9622", @"/Views/Autonoma/Contatar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115b1615ce6a7e84a90aae513a43b3313cacd377", @"/Views/_ViewImports.cshtml")]
    public class Views_Autonoma_Contatar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<site_projetosocial_squad5.Models.Autonoma>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProdutoServico", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: block;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"
<style>
    main{
        text-align: center;
    }
    .a_contato{
        padding: 20px;
        background-color: greenyellow;
        color: black;
        margin-top: 10px;
        border-radius: 10px;
    }
    
</style>

<main>
    <address>
    <h1>");
#nullable restore
#line 19 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\Autonoma\Contatar.cshtml"
   Write(Html.DisplayFor(model => model.nomeNegocio_autonoma));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Contato: <strong>");
#nullable restore
#line 20 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\Autonoma\Contatar.cshtml"
                   Write(Html.DisplayFor(model => model.telefone_autonoma));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\r\n    </address>\r\n    <hr class=\"hr_contato\">\r\n    <p>Clique nesse botão abaixo para falar com a vendedora no Whatsapp</p>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 602, "\"", 695, 2);
            WriteAttributeValue("", 609, "https://api.whatsapp.com/send?phone=", 609, 36, true);
#nullable restore
#line 24 "C:\Users\je_ss\OneDrive\Área de Trabalho\Projeto Mulheres\Squad-5_Projeto-Social-RecodePro\Recode-Pro-Squad-5-ProjetoSocial\site-projetosocial-squad5\Views\Autonoma\Contatar.cshtml"
WriteAttributeValue("", 645, Html.DisplayFor(model => model.telefone_autonoma), 645, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\" class=\"a_contato\">Contatar</a> \r\n    <hr>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d219e804cc05149358e4abea729fd1badda96226271", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n</main>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<site_projetosocial_squad5.Models.Autonoma> Html { get; private set; }
    }
}
#pragma warning restore 1591
