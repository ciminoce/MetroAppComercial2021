using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Comun.Repositorios
{
    public interface IBombonesRepositorio:IRepositorio<Bombon>
    {
        bool Existe(Bombon bombon);
        bool EstaRelacionado(Bombon bombon);

        int GetCantidad();
        List<Bombon> GetListaPaginada(int registros, int paginaActual);

        int ActualizarStock(Producto producto, int detalleVtaCantidad);
    }
}
