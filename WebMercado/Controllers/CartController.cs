using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMercado.Data;
using WebMercado.Helpers;
using WebMercado.Models;
using Microsoft.AspNetCore.Identity;

namespace WebMercado.Controllers
{
    public class CartController : Controller
    {
        private readonly WebMercadoContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        private readonly UserManager<Usuario> userManager;

        public CartController(WebMercadoContext context, IWebHostEnvironment webHost, UserManager<Usuario> user)
        {
            _context = context;
            webHostEnvironment = webHost;
            userManager = user;
        }


        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<Carrinho>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart == null ? 0 : cart.Items.Sum(item => item.Produto.ValorVenda * item.Quantidade);
            return View();
        }

        public Carrinho GetCarrinho()
        {
            if (SessionHelper.GetObjectFromJson<Carrinho>(HttpContext.Session, "cart") == null)
                return null;
            else
                return SessionHelper.GetObjectFromJson<Carrinho>(HttpContext.Session, "cart");
        }

        public IActionResult Adicionar(int id)
        {
            Produto produto = _context.Produtos.Find(id);
            Carrinho cart = new Carrinho();
            if (SessionHelper.GetObjectFromJson<Carrinho>(HttpContext.Session, "cart") == null)
            {
                cart.Items.Add(new Item { Produto = produto, Quantidade = 1, TotalItem = string.Format("R$ {0:N2}", produto.ValorVenda) });
            }
            else
            {
                cart = SessionHelper.GetObjectFromJson<Carrinho>(HttpContext.Session, "cart");
                int index = Existe(id, cart);
                if (index != -1)
                {
                    if (cart.Items[index].Quantidade < QuantidadeRestante(cart.Items[index].Produto.Id))
                    {
                        cart.Items[index].Quantidade++;
                        cart.Items[index].TotalItem = string.Format("R$ {0:N2}", cart.Items[index].Produto.ValorVenda * cart.Items[index].Quantidade);
                    }
                }
                else
                {
                    cart.Items.Add(new Item { Produto = produto, Quantidade = 1, TotalItem = string.Format("R$ {0:N2}", produto.ValorVenda) });
                }
            }
            cart.QtdeItens = cart.Items.Count();
            cart.ValorTotal = cart.Items.Sum(item => item.Produto.ValorVenda * item.Quantidade);
            cart.ValorTotalTexto = string.Format("R$ {0:N2}", cart.ValorTotal);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return PartialView("_CartPartial");
        }

        public IActionResult Diminuir(int id)
        {
            var cart = SessionHelper.GetObjectFromJson<Carrinho>(HttpContext.Session, "cart");
            int index = Existe(id, cart);
            if (index != -1)
            {
                if (cart.Items[index].Quantidade > 1)
                {
                    cart.Items[index].Quantidade--;
                    cart.Items[index].TotalItem = string.Format("R$ {0:N2}", cart.Items[index].Produto.ValorVenda * cart.Items[index].Quantidade);
                }
            }
            cart.QtdeItens = cart.Items.Count();
            cart.ValorTotal = cart.Items.Sum(item => item.Produto.ValorVenda * item.Quantidade);
            cart.ValorTotalTexto = string.Format("R$ {0:N2}", cart.ValorTotal);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return PartialView("_CartPartial");
        }


        public IActionResult Remover(int id)
        {
            var cart = SessionHelper.GetObjectFromJson<Carrinho>(HttpContext.Session, "cart");
            int index = Existe(id, cart);
            cart.Items.RemoveAt(index);
            cart.QtdeItens = cart.Items.Count();
            cart.ValorTotal = cart.Items.Sum(item => item.Produto.ValorVenda * item.Quantidade);
            cart.ValorTotalTexto = string.Format("R$ {0:N2}", cart.ValorTotal);
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
            return PartialView("_CartPartial");
        }

        /* [Authorize]
         public IActionResult Finalizar(Carrinho carrinho)
         {
             var cart = SessionHelper.GetObjectFromJson<Carrinho>(HttpContext.Session, "cart");
             if (cart.Items != null && cart.Items.Count > 0)
             {
                 foreach (var item in cart.Items)
                 {
                     var produto = _context.Produtos.Find(item.Produto.Id);
                     if (produto != null)
                     {
                         if (item.Quantidade <= produto.EstoqueAtual)
                         {
                             produto.EstoqueAtual -= item.Quantidade;
                             _context.SaveChangesAsync();


                         }
                         else
                         {
                             ModelState.AddModelError("", $"A quantidade solicitada para '{produto.Nome}' excede a quantidade em estoque!");
                         }
                     }
                 }

                 HttpContext.Session.Remove("cart");
             }

             return PartialView("_CartPartial");
         }*/

        [Authorize]
        public async Task<IActionResult> Finalizar(Carrinho carrinho)
        {
            var user = await userManager.GetUserAsync(User);

            var cart = SessionHelper.GetObjectFromJson<Carrinho>(HttpContext.Session, "cart");

            if (user != null)
            {
                if (cart.Items != null && cart.Items.Count > 0)
                {
                    using var transaction = _context.Database.BeginTransaction();

                    try
                    {
                        var novoPedido = new Pedido
                        {
                            DataPedido = DateTime.Now,
                            ValorTotal = cart.ValorTotal,
                            IdUser = user.Id
                        };

                        _context.Pedidos.Add(novoPedido);
                        _context.SaveChanges();

                        foreach (var item in cart.Items)
                        {
                            var produto = _context.Produtos.Find(item.Produto.Id);

                            if (produto != null)
                            {
                                if (item.Quantidade <= produto.EstoqueAtual)
                                {
                                    produto.EstoqueAtual -= item.Quantidade;

                                    var itemPedido = new ItemPedido
                                    {
                                        PedidoId = novoPedido.Id,
                                        ProdutoId = produto.Id,
                                        Quantidade = item.Quantidade,
                                        ValorTotal = produto.ValorVenda * item.Quantidade
                                    };

                                    _context.ItensPedidos.Add(itemPedido);
                                    _context.SaveChanges();
                                }
                                else
                                {
                                    ModelState.AddModelError("", $"A quantidade solicitada para '{produto.Nome}' excede a quantidade em estoque!");
                                    // Lide com o erro adequadamente
                                }
                            }
                        }


                        transaction.Commit();

                        HttpContext.Session.Remove("cart");
                    }
                    catch (DbUpdateException ex)
                    {

                        transaction.Rollback();

                        // Verifique a exceção interna para obter detalhes
                        var innerException = ex.InnerException;
                        var errorMessage = innerException?.Message;

                        // Faça algo com a mensagem de erro, como log ou depuração
                        Console.WriteLine("Inner Exception Message: " + errorMessage);
                        // Lide com o erro adequadamente
                    }
                }
            }
            else
            {
                ModelState.AddModelError("", "Não existe um usuário logado, por favor entre ou cadastre-se!");
            }

            

            return PartialView("_CartPartial");
        }






        public int Existe(int id, Carrinho cart)
        {
            int index = -1;
            int i = 0;
            foreach (var item in cart.Items)
            {
                if (item.Produto.Id == id)
                {
                    index = i;
                    break;
                }
                i += 1;
            }
            return index;
        }

        public int QuantidadeRestante(int id)
        {
            Produto produto = _context.Produtos.Find(id);
            int quantidadeDisponivel = produto.EstoqueAtual;

            return quantidadeDisponivel;
        }

        //C
        public IActionResult DetalhesProduto(int id)
        {
            Produto produto = _context.Produtos.Find(id);

            if (produto == null)
            {
                return NotFound();
            }

            int quantidadeDisponivelProduto = QuantidadeRestante(id); // Obtenha a quantidade disponível do método
            ViewBag.QuantidadeDisponivel = quantidadeDisponivelProduto;

            return View(produto);
        }

        

    }
}
