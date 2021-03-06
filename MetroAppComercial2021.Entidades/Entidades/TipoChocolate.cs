using System;
using System.Linq;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class TipoChocolate
    {
        public int TipoChocolateId { get; set; }
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
