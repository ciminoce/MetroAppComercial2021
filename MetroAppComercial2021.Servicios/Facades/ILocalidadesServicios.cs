using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface ILocalidadesServicios
    {
        List<Localidad> GetLista();
        List<Localidad> GetLista(int provinciaId);
        int Agregar(Localidad localidad);
        bool EstaRelacionado(Localidad localidad);
        bool Existe(Localidad localidad);
        int Borrar(Localidad localidad);
        int Editar(Localidad localidad);
        Localidad GetPorId(int id);

    }
}
