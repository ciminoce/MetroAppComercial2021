using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Comun.Repositorios
{
    public interface ILocalidadesRepositorio:IRepositorio<Localidad>
    {
        bool Existe(Localidad localidad);
        bool EstaRelacionado(Localidad localidad);
        List<Localidad> GetLista(int provinciaId);

    }
}
