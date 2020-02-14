using Entitidades.Concretas;
using Negocios.Abstractas;
using Negocios.Abstractas.Simples;
using Negocios.Concretas;
using Negocios.ResolverDependencias.Ninject;
using Ninject;
using Nucleo.Utilidades.Abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaUI
{
    class Program
    {

        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new ModuloNinject());
            IServicioIdiomas _servicioIdiomas = kernel.Get<IServicioIdiomas>();
            var a = _servicioIdiomas.GetAll("Nombre Like 'A%'","Nombre");
      //      a = _servicioIdiomas.Get(x=>x.Nombre=="Ingles");
            
            Console.WriteLine(a.ToString());
            Console.ReadKey();
        }
    }
}
