using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface IClientesServicios
    {
        List<Cliente> GetLista();
        bool Existe(Cliente cliente);
        int Agregar(Cliente cliente);
        int Editar(Cliente cliente);
        bool EstaRelacionado(Cliente cliente);
        int Borrar(Cliente cliente);
    }
}
