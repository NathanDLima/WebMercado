using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebMercado.Data;
using WebMercado.Models;

namespace WebMercado.Controllers
{
    public class PedidoController : Controller
    {
        private readonly WebMercadoContext _context;
        private readonly UserManager<Usuario> userManager;

        public PedidoController(WebMercadoContext context, UserManager<Usuario> user)
        {
            _context = context;
            userManager = user;
        }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var user = await userManager.GetUserAsync(User);
            var userId = user.Id;
            var pedidosDoUsuario = _context.Pedidos.Where(p => p.IdUser == userId).ToList();

            return View(pedidosDoUsuario);
        }
    }
}
