using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Datos.Comun.Repositorios
{
    public interface IUsuariosRepositorio
    {
        Usuario GetUsuario(int empleadoId, string password);
        List<Usuario> GetLista();
        bool Existe(Usuario usuario);
        int Agregar(Usuario usuario);
        int Editar(Usuario usuario);
        int Borrar(Usuario usuario);
    }
}
