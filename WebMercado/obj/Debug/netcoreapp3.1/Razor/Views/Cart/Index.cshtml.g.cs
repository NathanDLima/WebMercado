#pragma checksum "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d96c0fe4f7a3f382fbeea0e18cbdd7d569926117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\_ViewImports.cshtml"
using WebMercado;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\_ViewImports.cshtml"
using WebMercado.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
using WebMercado.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d96c0fe4f7a3f382fbeea0e18cbdd7d569926117", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6982e6cce3a911c92f41e2ddae08ea3c706a28e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Produtos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn cart-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("primary-btn cart-btn cart-btn-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Carrinho";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Breadcrumb Section Begin -->
<section class=""breadcrumb-section set-bg"" data-setbg=""../img/breadcrumb.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12 text-center"">
                <div class=""breadcrumb__text"">
                    <h2>Carrinho</h2>
                    <div class=""breadcrumb__option"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d96c0fe4f7a3f382fbeea0e18cbdd7d5699261176522", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        <span>Home</span>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Breadcrumb Section End -->
<!-- Shoping Cart Section Begin -->
<section class=""shoping-cart spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""shoping__cart__table"">
");
#nullable restore
#line 30 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                     if (ViewBag.cart != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table>
                            <thead>
                                <tr>
                                    <th class=""shoping__product"">Produtos</th>
                                    <th>Preço</th>
                                    <th>Quantidade</th>
                                    <th>Total</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 43 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                                 foreach (var item in ViewBag.cart.Items)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td class=\"shoping__cart__item\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 1874, "\"", 1913, 1);
#nullable restore
#line 47 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1880, Url.Content(item.Produto.Imagem), 1880, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1914, "\"", 1920, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <h5>");
#nullable restore
#line 48 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                                           Write(item.Produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        </td>\r\n                                        <td class=\"shoping__cart__price\">\r\n                                            ");
#nullable restore
#line 51 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                                       Write(string.Format("R$ {0:N2}", item.Produto.ValorVenda));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </td>
                                        <td class=""shoping__cart__quantity"">
                                            <div class=""quantity"">
                                                <div class=""pro-qty"" data-quantidade-disponivel=""");
#nullable restore
#line 55 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                                                                                            Write(ViewBag.QuantidadeDisponivel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                                                    <input");
            BeginWriteAttribute("id", " id=\"", 2598, "\"", 2642, 1);
#nullable restore
#line 56 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2603, string.Concat("item", item.Produto.Id), 2603, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"number\"");
            BeginWriteAttribute("value", " value=\"", 2657, "\"", 2681, 1);
#nullable restore
#line 56 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2665, item.Quantidade, 2665, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                </div>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td");
            BeginWriteAttribute("id", " id=\'", 2883, "\'", 2925, 1);
#nullable restore
#line 60 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
WriteAttributeValue("", 2888, string.Concat("sp", item.Produto.Id), 2888, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"shoping__cart__total\">\r\n                                            ");
#nullable restore
#line 61 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                                       Write(string.Format("R$ {0:N2}", item.Produto.ValorVenda * item.Quantidade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td class=\"shoping__cart__item__close\">\r\n                                            <span class=\"icon_close\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3270, "\"", 3309, 3);
            WriteAttributeValue("", 3280, "excluirItem(", 3280, 12, true);
#nullable restore
#line 64 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
WriteAttributeValue("", 3292, item.Produto.Id, 3292, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3308, ")", 3308, 1, true);
            EndWriteAttribute();
            WriteLiteral("></span>\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 67 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n");
#nullable restore
#line 70 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h1>Carrinho vazio</h1>\r\n");
#nullable restore
#line 74 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <div class=\"shoping__cart__btns\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d96c0fe4f7a3f382fbeea0e18cbdd7d56992611715168", async() => {
                WriteLiteral("CONTINUE COMPRANDO");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d96c0fe4f7a3f382fbeea0e18cbdd7d56992611716645", async() => {
                WriteLiteral("\r\n                        <span class=\"icon_loading\"></span>\r\n                        Atualizar Carrinho\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
            <div class=""col-lg-6"">
                <div class=""shoping__continue"">
                    <div class=""shoping__discount"">
                        <h5>Cupons de Desconto</h5>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d96c0fe4f7a3f382fbeea0e18cbdd7d56992611718482", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Insira o seu cupom\">\r\n                            <button type=\"submit\" class=\"site-btn\">APLICAR CUPOM</button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""col-lg-6"">
                <div class=""shoping__checkout"">
                    <h5>Valor total do carrinho</h5>
                    <ul>
                        <li>Subtotal <span id=""subTotal"">");
#nullable restore
#line 105 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                                                    Write(string.Format("R$ {0:N2}", ViewBag.total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                        <li>Total <span id=\"total\">");
#nullable restore
#line 106 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                                              Write(string.Format("R$ {0:N2}", ViewBag.total));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                    </ul>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 5190, "\"", 5197, 0);
            EndWriteAttribute();
            WriteLiteral(" data-ajax=\"true\" data-ajax-complete=\"finalizado\" class=\"primary-btn\">FINALIZAR COMPRA</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Shoping Cart Section End -->\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script type=""text/javascript"">
        // Função para aumentar a quantidade
        function aumentarQuantidade(elemento) {
            var id = elemento.target.previousElementSibling.id.substring(4);
            $.ajax({
                type: ""GET"",
                url: ""/Cart/Adicionar"",
                data: { id: id },
                success: function (data) {
                    atualizarItens();
                    $('#cartPartial').html(data);
                    document.location.reload(true);
                    
                }
            });
        };

        // Função para alterar os valores em exibição
        function atualizarItens() {
             $.ajax({
                type: ""GET"",
                url: ""/Cart/GetCarrinho"",
                success: function (data) {
                    for (var i = 0; i < data.items.length; i++) {
                        document.getElementById('sp' + data.items[i].produto.id).innerHTML = data.items[i].totalItem;
     ");
                WriteLiteral(@"               }
                    document.getElementById('subTotal').innerHTML = data.valorTotalTexto;
                    document.getElementById('total').innerHTML = data.valorTotalTexto;
                }
            });
        }

        // Função para diminuir a quantidade
        function diminuirQuantidade(elemento) {
            var id = elemento.target.nextElementSibling.id.substring(4);
            $.ajax({
                type: ""GET"",
                url: ""/Cart/Diminuir"",
                data: { id: id },
                success: function (data) {
                    atualizarItens();
                    $('#cartPartial').html(data);
                    document.location.reload(true);
                }
            });
        };

        // Função para remover o produto
        var excluirItem = function (id) {
            $.ajax({
                type: ""GET"",
                url: ""/Cart/Remover"",
                data: { id: id },
                success: function ");
                WriteLiteral(@"(data) {
                    document.location.reload(true);
                }
            });
        }

        // Função para finalizar a compra e retirar os items no banco
        var finalizarCompra = function (carrinho) {
            $.ajax({
                type: ""GET"",
                url: ""/Cart/Finalizar"",
                data: {carrinho: carrinho},
                success: function (data) {
                    atualizarItens();
                    //document.location.reload(true);
                    $('#cartPartial').html(data);
                    
                }
            })
        }


        finalizado = function (xhr) {
            swal({
                title: ""Compra finalizada!"",
                icon: ""success"",
                buttons: {
                    goHome: { text: ""Voltar para a Home"", value: ""goHome"" }
                }
            })
                .then((value) => {
                    if (value == ""goHome"") {
                        fina");
                WriteLiteral("lizarCompra();\r\n                        window.location.href = \'");
#nullable restore
#line 204 "C:\Estudos Programação\FATEC\Artigo\WebMercado\WebMercado\Views\Cart\Index.cshtml"
                                           Write(Url.Action("Index", "Home"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';

                    };
                });
        };

        var addButton = document.getElementsByClassName(""inc qtybtn"");
        Array.from(addButton).forEach(function (element) {
            element.addEventListener('click', aumentarQuantidade);
        });

        var minusButton = document.getElementsByClassName(""dec qtybtn"");
        Array.from(minusButton).forEach(function (element) {
            element.addEventListener('click', diminuirQuantidade);
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
