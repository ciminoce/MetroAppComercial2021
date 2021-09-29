using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface INuecesServicios
    {
        List<TipoNuez> GetLista();
        int Agregar(TipoNuez tipoNuez);
        bool EstaRelacionado(TipoNuez tipoNuez);
        bool Existe(TipoNuez tipoNuez);
        int Borrar(TipoNuez tipoNuez);
        int Editar(TipoNuez tipoNuez);
        TipoNuez GetPorId(int id);

    }
}
