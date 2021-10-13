using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public int EmpleadoId { get; set; }
        public int RolId { get; set; }
        public string Password { get; set; }
        public byte[] RowVersion { get; set; }
        public Empleado Empleado { get; set; }
        public Rol Rol { get; set; }

        public bool TienePermiso(string tarea)
        {
            var encontrado = Rol.NoPermisosRoles.Any(p => p.Permiso.NombrePermiso == tarea);
            return !encontrado;
            //return x;
        }
    }
}
