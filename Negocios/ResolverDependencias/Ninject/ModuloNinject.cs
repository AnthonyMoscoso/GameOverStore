using AccesoDatos.Abstractas;
using AccesoDatos.Abstractas.ASimples;
using AccesoDatos.Abstractas.AUsuario;
using AccesoDatos.Abstractas.Compuestas;
using AccesoDatos.Abstractas.Lineas;
using AccesoDatos.Abstractas.Simples;
using AccesoDatos.Concretas.Dapper;
using AccesoDatos.Concretas.Dapper.Compuestas;
using AccesoDatos.Concretas.Dapper.Lineas;
using AccesoDatos.Concretas.Dapper.Simples;
using AccesoDatos.Concretas.Dapper.Usuario;
using AccesoDatos.Concretas.File;
using Negocios.Abstractas;
using Negocios.Abstractas.Compuestas;
using Negocios.Abstractas.Lineas;
using Negocios.Abstractas.Simples;
using Negocios.Abstractas.Users;
using Negocios.Concretas;
using Negocios.Concretas.Compuestas;
using Negocios.Concretas.Lineas;
using Negocios.Concretas.Simples;
using Negocios.Concretas.Users;
using Ninject.Modules;
using Nucleo.Utilidades.Abstracta;
using Nucleo.Utilidades.Concreta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.ResolverDependencias.Ninject
{
    public class ModuloNinject : NinjectModule
    {
        public override void Load()
        {

            //Devoluciones 
            Bind<IServicioDevoluciones>().To<GestorDevoluciones>().InSingletonScope();
            Bind<IDevolucionesDal>().To<DapDevolucionesDal>().InSingletonScope();
            //Pedidos
            Bind<IServicioPedidos>().To<GestorPedidos>().InSingletonScope();
            Bind<IPedidosDal>().To<DapPedidosDal>().InSingletonScope();
            //Productos
            Bind<IServicioProductos>().To<GestorProductos>().InSingletonScope();
            Bind<IProductosDal>().To<DapProductosDal>().InSingletonScope();
            //Reservas
            Bind<IServicioReservas>().To<GestorReservas>().InSingletonScope();
            Bind<IReservasDal>().To<DapReservasDal>().InSingletonScope();
            //Ventas
            Bind<IServicioVentas>().To<GestorVentas>().InSingletonScope();
            Bind<IVentasDal>().To<DapVentasDal>().InSingletonScope();
            //LineaPedidos
            Bind<IServicioLineaPedidos>().To<GestorLineaPedidos>().InSingletonScope();
            Bind<ILineaPedidosDal>().To<DapLineaPedidosDal>().InSingletonScope();
            //LineaVentas
            Bind<IServicioLineaVentas>().To<GestorLineaVentas>().InSingletonScope();
            Bind<ILineaVentasDal>().To<DapLineaVentasDal>().InSingletonScope();
            //Generos
            Bind<IServicioGeneros>().To<GestorGeneros>().InSingletonScope();
            Bind<IGenerosDal>().To<DapGenerosDal>().InSingletonScope();
            //Idiomas 
            Bind<IServicioIdiomas>().To<GestorIdiomas>().InSingletonScope();
            Bind<IIdiomasDal>().To<DapIdiomasDal>().InSingletonScope();
            //Desarrolladoras
            Bind<IServicioDesarrolladoras>().To<GestorDesarrolladoras>().InSingletonScope();
            Bind<IDesarrolladorasDal>().To<DapDesarrolladorasDal>().InSingletonScope();
            //Plataformas
            Bind<IServicioPlataformas>().To<GestorPlataformas>().InSingletonScope();
            Bind<IPlataformasDal>().To<DapPlataformasDal>().InSingletonScope();
            //Permisos
            Bind<IServicioPermisos>().To<GestorPermisos>().InSingletonScope();
            Bind<IPermisosDal>().To<DapPermisosDal>().InSingletonScope();
            //Socios
            Bind<IServicioSocios>().To<GestorSocios>().InSingletonScope();
            Bind<ISociosDal>().To<DapSociosDal>().InSingletonScope();
            //Usuarios
            Bind<IUsuarioDal>().To<DapUsuarioDal>().InSingletonScope();
            Bind<IServicioUsuarios>().To<GestorUsuario>().InSingletonScope();
            //Calificaciones
            Bind<IClasificacionesDal>().To<DapClasificacionesDal>().InSingletonScope();
            Bind<IServicioClasificaciones>().To<GestorClasificaciones>().InSingletonScope();

            //Personas
            Bind<IPersonasDal>().To<DapPersonasDal>().InSingletonScope();
            Bind<IServicioPersona>().To<GestorPersonas>().InSingletonScope();



            Bind<IServicioCrypto>().To<CryptoAes>().InSingletonScope();

        }
    }
}