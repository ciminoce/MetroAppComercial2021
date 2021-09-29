﻿namespace MetroAppComercial2021.Entidades.Entidades
{
    public class Localidad
    {
        public int LocalidadId { get; set; }
        public string NombreLocalidad { get; set; }
        public int ProvinciaId { get; set; }
        public Provincia Provincia { get; set; }

        public byte[] RowVersion { get; set; }

    }
}
