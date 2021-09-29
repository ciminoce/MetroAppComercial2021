using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface IProveedoresServicios
    {
        List<Proveedor> GetLista();
        bool Existe(Proveedor cliente);
        int Agregar(Proveedor cliente);
        int Editar(Proveedor cliente);

    }
}
