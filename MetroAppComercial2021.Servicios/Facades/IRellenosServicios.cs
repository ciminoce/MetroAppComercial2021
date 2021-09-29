using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface IRellenosServicios
    {
        List<TipoRelleno> GetLista();
        int Agregar(TipoRelleno tipoRelleno);
        bool EstaRelacionado(TipoRelleno tipoRelleno);
        bool Existe(TipoRelleno tipoRelleno);
        int Borrar(TipoRelleno tipoRelleno);
        int Editar(TipoRelleno tipoRelleno);
        TipoRelleno GetPorId(int id);

    }
}
