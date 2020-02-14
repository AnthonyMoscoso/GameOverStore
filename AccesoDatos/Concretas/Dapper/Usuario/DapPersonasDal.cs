using AccesoDatos.Abstractas.AUsuario;
using Entitidades.Users;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.Dapper.Usuario
{
    public class DapPersonasDal : DapBaseRepositorioEntitidad<Personas, DapperContexto>, IPersonasDal
    {
        public DapPersonasDal() : base(
            tableName: "Persona",
            colums: "Id,Nombre,Apellido,Email,Contraseña,Telefono,Imagen,Tipo",
            parameters: "@Id,@Nombre,@Apellido,@Email,@Contraseña,@Telefono,@Imagen,@Tipo")
        {

        }
    }
}
