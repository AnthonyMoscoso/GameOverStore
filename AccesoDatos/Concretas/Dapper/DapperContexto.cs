using Nucleo.AccesoDatos.Abstractas;

namespace AccesoDatos.Concretas.Dapper
{
    public class DapperContexto : IContexto
    {
        public string CadenaConexion { get; set; }
        public DapperContexto()
        {
            CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\2_dam\Interfaces\GameOverStore\ConsolaUI\Database.mdf;Integrated Security=True";
        }
    }
}
