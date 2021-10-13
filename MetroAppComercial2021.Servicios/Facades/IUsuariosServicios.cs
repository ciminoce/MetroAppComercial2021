using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Servicios.Facades
{
    public interface IUsuariosServicios
    {
        Usuario GetUsuario(int empleadoId, string password);

        List<Usuario> GetLista();
        bool Existe(Usuario usuario);
        int Agregar(Usuario usuario);
        int Borrar(Usuario usuario);
        int Editar(Usuario usuario);
    }
}
