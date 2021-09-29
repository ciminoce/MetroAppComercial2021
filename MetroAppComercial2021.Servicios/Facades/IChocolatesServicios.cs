using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface IChocolatesServicios
    {
        List<TipoChocolate> GetLista();
        int Agregar(TipoChocolate tipoChocolate);
        bool EstaRelacionado(TipoChocolate tipoChocolate);
        bool Existe(TipoChocolate tipoChocolate);
        int Borrar(TipoChocolate tipoChocolate);
        int Editar(TipoChocolate tipoChocolate);
        TipoChocolate GetPorId(int id);

    }
}
