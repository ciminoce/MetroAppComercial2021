using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class NoPermisoRol
    {
        public int NoPermisoRolId { get; set; }
        public int RolId { get; set; }
        public int PermisoId { get; set; }
        public Rol Rol { get; set; }
        public Permiso Permiso { get; set; }
    }
}
