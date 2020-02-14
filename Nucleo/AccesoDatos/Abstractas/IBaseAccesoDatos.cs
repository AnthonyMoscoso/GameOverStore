using Nucleo.Entidades;

namespace Nucleo.AccesoDatos.Abstractas
{
    public interface IBaseAccesoDatos<T> : IRepositorioEntidad<T> where T : class, IEntidad, new()
    {
    }
    
}
