using System.Diagnostics;
using System.Threading.Tasks;
using Intranet.Models;
using Intranet.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Intranet.Controllers
{
    public class HomeController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public async Task<List<ContatoModel>> ListarAsync()
        {
            return await _context.Contatos.ToListAsync();
        }


        public HomeController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }

        public async Task<IActionResult> Index()
        {
            var lista = await _contatoRepositorio.ListarAsync();
            return View(lista);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
