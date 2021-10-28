using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Comun.Repositorios
{
    public interface IVentasRepositorio
    {
        List<Venta> GetListaPaginada(int registros, int paginaActual);
        List<Venta> GetLista();
        List<Venta> GetLista(int clienteId, int registros, int paginaActual);
        List<Venta> GetLista(DateTime fechaVenta, int registros, int paginaActual);
        Venta GetVentaPorId(int ventaId);
        int Agregar(Venta venta);

        int GetCantidad();
        int GetCantidad(int clienteId);
        int GetCantidad(DateTime fechaBusqueda);
    }
}
