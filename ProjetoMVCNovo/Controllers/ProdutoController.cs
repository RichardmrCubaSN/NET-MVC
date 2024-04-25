using Microsoft.AspNetCore.Mvc;
using ProjetoMVCNovo.Models;

namespace ProjetoMVCNovo.Controllers
{
    public class ProdutoController : Controller
    {
        public int Id { get; private set; }
        public string? Descricao { get; private set; }
        public object? Produto { get; private set; }

        private static List<ProdutoViewModel>? produtos = new List<ProdutoViewModel>();

        public IActionResult Index()
        {
            return View(produtos);
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(ProdutoViewModel produtos)
        {
            produtos.Add(Produto);
            return View("index", produtos);
        }
    }
}
