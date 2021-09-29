using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface IProvinciasServicios
    {
        List<Provincia> GetLista();
        int Agregar(Provincia provincia);
        bool EstaRelacionado(Provincia provincia);
        bool Existe(Provincia provincia);
        int Borrar(Provincia provincia);
        int Editar(Provincia provincia);
        Provincia GetPorId(int id);

    }
}
