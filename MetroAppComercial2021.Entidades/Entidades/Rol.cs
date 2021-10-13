using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class Rol
    {
        public int RolId { get; set; }
        public string NombreRol { get; set; }
        public byte[] RowVersion { get; set; }
        public List<NoPermisoRol> NoPermisosRoles { get; set; }
    }
}
