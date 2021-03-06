﻿using Entitidades.Concretas;
using Nucleo.AccesoDatos.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Abstractas.Simples
{
    public interface IIdiomasDal : IRepositorioEntidad<Idiomas>
    {
        List<Idiomas> GetIdiomasByIdProducto(int Id);
    }
}
