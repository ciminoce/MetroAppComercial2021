using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Comun.Repositorios
{
    public interface IProvinciasRepositorio:IRepositorio<Provincia>
    {
        bool EstaRelacionado(Provincia provincia);
        bool Existe(Provincia provincia);

    }
}
