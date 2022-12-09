using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLeitura.HTML
{
    public class HtmlUtils
    {
        public static string CarregaArquivoHTML(string nomeDoArquivo)
        {
            var nomeCompletoArquivo = $"K:\\Projetos\\ListaLeitura\\ListaLeitura\\HTML\\{nomeDoArquivo}.html";
            using (var arquivo = File.OpenText(nomeCompletoArquivo))
            {
                return arquivo.ReadToEnd();
            }
        }
    }
}
