using AccesoDatos.Abstractas;
using AccesoDatos.Abstractas.ASimples;
using Entitidades.Concretas;
using Entitidades.Simples;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.Dapper.Simples
{
    public class DapDesarrolladorasDal : DapBaseRepositorioEntitidad<Desarrolladoras, DapperContexto>, IDesarrolladorasDal
    {
        public DapDesarrolladorasDal() : base(
            tableName: "Desarrolladoras",
            colums: "Nombre,Imagen",
            parameters: "@Nombre,@Imagen")
        {

        }
    }
}
