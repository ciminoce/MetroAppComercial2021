using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public abstract class Persona
    {
        public int Id { get; set; }
        public string Apellido { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public int ProvinciaId { get; set; }
        public int LocalidadId { get; set; }
        public string CodPostal { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string Mail { get; set; }
        public Provincia Provincia { get; set; }
        public Localidad Localidad { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
