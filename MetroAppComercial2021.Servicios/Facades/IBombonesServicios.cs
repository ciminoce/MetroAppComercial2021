using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface IBombonesServicios
    {
        List<Bombon> GetLista();
        bool Existe(Bombon bombon);
        int Agregar(Bombon bombon);
        int Editar(Bombon bombon);
        bool EstaRelacionado(Bombon bombon);
        int Borrar(Bombon bombon);
        int GetCantidad();
        List<Bombon> GetListaPaginada(int registros, int paginaActual);
    }
}
