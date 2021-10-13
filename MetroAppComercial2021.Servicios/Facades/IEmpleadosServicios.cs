using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface IEmpleadosServicios
    {
        List<Empleado> GetLista();
        bool Existe(Empleado empleado);
        int Agregar(Empleado empleado);
        int Editar(Empleado empleado);
        bool EstaRelacionado(Empleado empleado);
        int Borrar(Empleado empleado);

    }
}
