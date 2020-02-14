
using AccesoDatos.Abstractas;
using Entitidades.Concretas;
using LinqKit;
using Negocios.Abstractas;
using Negocios.Abstractas.Users;
using Negocios.Concretas.Users;
using Nucleo.Negocios.Concreto;
using Nucleo.Utilidades.Abstracta;
using System.Collections.Generic;

namespace Negocios.Concretas
{
    public class GestorUsuario : BaseServicio<Usuarios>, IServicioUsuarios
    {
        private IServicioCrypto _cryptoService;
        public GestorUsuario(IUsuarioDal articleDal, IServicioCrypto cryptoService) : base(articleDal)
        {
            _cryptoService = cryptoService;
            
        }

        public bool ChequeaContraseña(Usuarios user, string password)
        {
            return _cryptoService.Desencriptar(user.Contraseña, user.Contraseña) == password;
        }

        //Para la construcción de consultas avanzadas se puede utilizar linqkit http://www.albahari.com/nutshell/predicatebuilder.aspx
        //para pobrar vuestras implementaciones linqpad
    
    }
    
}
