#pragma checksum "C:\Users\DELL-TI\CalculadoraJS\DOMExemplo\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5459a2ae169803d397523832c996aa85156dfe37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Privacy.cshtml", typeof(AspNetCore.Views_Home_Privacy))]
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
#line 1 "C:\Users\DELL-TI\CalculadoraJS\DOMExemplo\Views\_ViewImports.cshtml"
using DOMExemplo;

#line default
#line hidden
#line 2 "C:\Users\DELL-TI\CalculadoraJS\DOMExemplo\Views\_ViewImports.cshtml"
using DOMExemplo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5459a2ae169803d397523832c996aa85156dfe37", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a579253b45e98005cc3b0ff0143d92e538d03c8b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2902, true);
            WriteLiteral(@"<style>
    .button {
        width: 3.125rem;
        height: 3.125rem;
    }

    .divisor {
        width: 14rem;
        margin-left: 0.25rem;
    }

    .linha {
        height: 0.625rem;
    }

    .cinza {
        color: darkgray;
    }
</style>
<div class=""divisor"">
    <h5 class=""text-right cinza"">1232</h5>
</div>
<div class=""divisor"">
    <hr>
    <h2 class=""text-right"" id=""texto1"">1232</h2>
    <hr>
</div>
<div class=""row ml-0"">
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""CE"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""C"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""<"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""/"" />
    </div>
</div>
<div class=""row ml-0"">
    <div class=""m-1"">
        <input type=""button"" class=""btn ");
            WriteLiteral(@"btn-outline-dark button"" value=""7"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""8"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""9"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""*"" />
    </div>
</div>
<div class=""row ml-0"">
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""4"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""5"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""6"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""-"" />
    </div>
</div>
<div class=""row ml-0"">
    <div class=""m-1"">
        <input type=""button"" id=""numero"" class=""btn btn-outline-dark button"" value=""1"" /");
            WriteLiteral(@">
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""2"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""3"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""+"" />
    </div>
</div>
<div class=""row ml-0"">
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value="""" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""0"" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value="","" />
    </div>
    <div class=""m-1"">
        <input type=""button"" class=""btn btn-outline-dark button"" value=""="" />
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2920, 535, true);
                WriteLiteral(@"
    <script>
        function text1(valor) {
            document.getElementById(""texto1"").innerHTML = valor;
        }

        var btns = document.getElementsByClassName(""btn"");
        var valor;
        for (var i = 0; btns.length; i++) {
            btns[i].onclick = function () {
                text1(this.value);
            }
            //valor = btns[i].value;
            //btns[i].addEventListener('click', function () {
            //    text1(valor);
            //}, false);
        }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
