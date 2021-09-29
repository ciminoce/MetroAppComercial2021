using System;
using System.Linq;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class Provincia
    {
        public int ProvinciaId { get; set; }
        public string NombreProvincia { get; set; }
        public byte[] RowVersion { get; set; }

        public bool Validar()
        {
            bool esValido = true;
            if (string.IsNullOrEmpty(NombreProvincia) || string.IsNullOrWhiteSpace(NombreProvincia))
            {
                return false;
            }

            esValido = NombreProvincia.Replace(" ", "").All(Char.IsLetter);
            return esValido;
        }

    }
}
