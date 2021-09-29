using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroComercial2021.Entidades
{
    public class TipoNuez
    {
        public int TipoNuezId { get; set; }
        public string Descripcion { get; set; }
        public byte[] RowVersion { get; set; }
        public bool Validar()
        {
            bool esValido = true;
            if (string.IsNullOrEmpty(Descripcion) || string.IsNullOrWhiteSpace(Descripcion))
            {
                return false;
            }

            esValido = Descripcion.Replace(" ", "").All(Char.IsLetter);
            return esValido;
        }

    }
}
