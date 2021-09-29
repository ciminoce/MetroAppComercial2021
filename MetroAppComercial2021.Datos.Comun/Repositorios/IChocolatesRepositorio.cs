using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Comun.Repositorios
{
    public interface IChocolatesRepositorio:IRepositorio<TipoChocolate>
    {
        bool Existe(TipoChocolate tipoChocolate);
        bool EstaRelacionado(TipoChocolate tipoChocolate);
    }
}
