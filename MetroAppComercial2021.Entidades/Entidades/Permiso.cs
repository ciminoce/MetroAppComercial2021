using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class Permiso
    {
        public int PermisoId { get; set; }
        public int MenuId { get; set; }
        public string NombrePermiso { get; set; }
        public byte[] RowVersion { get; set; }
        public Menu Menu { get; set; }

    }
}
