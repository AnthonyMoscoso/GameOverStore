using AccesoDatos.Abstractas.Compuestas;
using Entitidades.Concretas;
using Entitidades.Simples;
using Negocios.Abstractas.Compuestas;
using Nucleo.Negocios.Concreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Concretas.Compuestas
{
    class GestorProductos : BaseServicio<Productos>, IServicioProductos
    {
       
        public GestorProductos(IProductosDal ProductosDal) : base(ProductosDal)
        {
           
        }

       

   

       
    }
}
