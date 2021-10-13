using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface INoPermisosServicios
    {
        List<NoPermisoRol> GetLista(int rolId);

    }
}
