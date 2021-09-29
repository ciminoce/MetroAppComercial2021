using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class Proveedor:Persona
    {
        public string NombreFantasia { get; set; }
        public override string ToString()
        {
            return $"{Apellido.ToUpper()}, {Nombres}";
        }
    }
}
