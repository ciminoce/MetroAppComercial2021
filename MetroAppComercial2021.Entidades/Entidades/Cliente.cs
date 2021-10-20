using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class Cliente:Persona
    {
        public override string ToString()
        {
            return $"{Apellido.ToUpper()}, {Nombres}";
        }

        public string ApeNombre => $"{Apellido} {Nombres}";
    }
}
