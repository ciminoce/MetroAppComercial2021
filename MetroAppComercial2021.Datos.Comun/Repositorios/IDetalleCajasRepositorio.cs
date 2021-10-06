﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Comun.Repositorios
{
    public interface IDetalleCajasRepositorio
    {
        List<DetalleCaja> GetLista(int cajaId);
        int Agregar(DetalleCaja detalleCaja);
        int Borrar(DetalleCaja detalle);
    }
}
