using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Comun.Repositorios
{
    public interface ICajasRepositorio:IRepositorio<Caja>
    {
        bool Existe(Caja caja);
        bool EstaRelacionado(Caja caja);

        int GetCantidad();
        List<Caja> GetListaPaginada(int registros, int paginaActual);

        int ActualizarStock(Producto producto, int cantidad);
    }
}
