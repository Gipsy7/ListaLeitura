using ListaLeitura.HTML;
using ListaLeitura.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace ListaLeitura.Logica
{
    public class LivrosController : Controller
    {
        public string Detalhes(int id)
        {
            var _repo = new LivroRepositorioCSV();

            var livro = _repo.Todos.First(x => x.Id == id);
            return livro.Detalhes();
        }

        //public string ParaLer()
        //{
        //    var conteudoArquivo = HtmlUtils.CarregaArquivoHTML("para-ler");
        //    var _repo = new LivroRepositorioCSV();

        //    foreach (var livro in _repo.ParaLer.Livros)
        //    {
        //        conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM#", $"<li>{livro.Titulo} - {livro.Autor}</li>#NOVO-ITEM#");
        //    }
        //    conteudoArquivo = conteudoArquivo.Replace("#NOVO-ITEM#", "");

        //    return conteudoArquivo;
        //}

        public IActionResult ParaLer()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.ParaLer.Livros;
            return View("para-ler");
        }

        public IActionResult Lendo()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lendo.Livros;
            return View("lendo");
        }

        public IActionResult Lidos()
        {
            var _repo = new LivroRepositorioCSV();
            ViewBag.Livros = _repo.Lidos.Livros;
            return View("lidos");
        }

        public string Teste() 
        {
            return "Nova funcionalidade teste";
        }
    }
}
