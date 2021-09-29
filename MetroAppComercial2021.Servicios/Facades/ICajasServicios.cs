using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface ICajasServicios
    {
        List<Caja> GetLista();
        bool Existe(Caja caja);
        int Agregar(Caja caja);
        int Editar(Caja caja);
        bool EstaRelacionado(Caja caja);
        int Borrar(Caja caja);
        int GetCantidad();
        List<Caja> GetListaPaginada(int registros, int paginaActual);
        Caja GetCajaConDetalle(int cajaId);

    }
}
