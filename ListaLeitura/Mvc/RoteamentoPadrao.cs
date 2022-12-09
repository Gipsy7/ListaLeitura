using ListaLeitura.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ListaLeitura.Mvc
{
    public class RoteamentoPadrao
    {
        public static Task TratamentoPadrao(HttpContext context) 
        {
            //rota padrão: /<Classe>Logica/Metodo

            var classe = StringUtils.FirstCharToUpper(context.GetRouteValue("classe").ToString().ToLower());
            var Nomemetodo = StringUtils.FirstCharToUpper(context.GetRouteValue("metodo").ToString());


            var x = $"ListaLeitura.Logica.{classe}Logica";

            var tipo = Type.GetType(x);
            var metodo = tipo?.GetMethods().Where( m => m.Name == Nomemetodo).First();

            var requestDelegate = (RequestDelegate)Delegate.CreateDelegate(typeof(RequestDelegate), metodo);

            return requestDelegate.Invoke(context);
        }    
    }
}
