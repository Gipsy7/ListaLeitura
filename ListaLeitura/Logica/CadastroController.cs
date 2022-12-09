using ListaLeitura.HTML;
using ListaLeitura.Negocio;
using ListaLeitura.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace ListaLeitura.Logica
{
    public class CadastroController
    {
        public string Incluir(Livro livro)
        {
            var _repo = new LivroRepositorioCSV();
            var novoLivro = new Livro()
            {
                Titulo = livro.Titulo,
                Autor = livro.Autor
            };

            _repo.Incluir(novoLivro);
            return "Livro adicionado com sucesso!";
        }

        public IActionResult ExibeFormulario()
        {
            //var html = HtmlUtils.CarregaArquivoHTML("Formulario").ToString();
            var html = new ViewResult { ViewName = "Formulario"};
            return html;
        }
    }
}
