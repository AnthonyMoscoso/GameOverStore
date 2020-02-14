using AccesoDatos.Abstractas.Compuestas;
using Entitidades.Concretas;
using Negocios.Abstractas.Users;
using Nucleo.Negocios.Concreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Concretas.Compuestas
{
   public class GestorPedidos : BaseServicio<Pedidos>, IServicioPedidos
    {
        public GestorPedidos(IPedidosDal PedidosDal) : base(PedidosDal)
        {

        }
    }
    
    
}
