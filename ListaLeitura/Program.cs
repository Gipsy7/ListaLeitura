using ListaLeitura.Negocio;
using ListaLeitura.Repositorio;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

var _repo = new LivroRepositorioCSV();

IWebHost host;

host = WebHost.CreateDefaultBuilder()
    .UseKestrel()
    .UseStartup<Startup>()
    .Build();
host.Run();

ImprimeLista(_repo.ParaLer);
ImprimeLista(_repo.Lendo);
ImprimeLista(_repo.Lidos);

static void ImprimeLista(ListaDeLeitura lista)
{
    Console.WriteLine(lista);
}