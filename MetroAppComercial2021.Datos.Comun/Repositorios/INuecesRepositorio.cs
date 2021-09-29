using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Comun.Repositorios
{
    public interface INuecesRepositorio:IRepositorio<TipoNuez>
    {
        bool Existe(TipoNuez tipoNuez);
        bool EstaRelacionado(TipoNuez tipoNuez);

    }
}
