using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class Empleado:Persona
    {
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaContratacion { get; set; }
        public bool Activo { get; set; }

        public string ApeNombre
        {
            get { return $"{Apellido}, {Nombres}"; }
        }

        public override string ToString()
        {
            return $"{Apellido.ToUpper()}, {Nombres}";
        }

    }
}
