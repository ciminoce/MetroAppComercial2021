using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Reportes.GestoresDeDatos
{
    public static class GestorDatosCiudades
    {
        public static AppComercialDataSet GetDataSet(List<Localidad> lista)
        {
            AppComercialDataSet ds = new AppComercialDataSet();
            foreach (var localidad in lista)
            {
                ds.Tables["Ciudades"].Rows
                    .Add(localidad.NombreLocalidad, localidad.Provincia.NombreProvincia);
            }

            return ds;
        }
    }
}
