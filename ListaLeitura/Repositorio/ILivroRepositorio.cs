using ListaLeitura.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLeitura.Repositorio
{
    interface ILivroRepositorio
    {
        ListaDeLeitura ParaLer { get; }
        ListaDeLeitura Lendo { get; }
        ListaDeLeitura Lidos { get; }
        IEnumerable<Livro> Todos { get; }
        void Incluir(Livro livro);
    }
}
