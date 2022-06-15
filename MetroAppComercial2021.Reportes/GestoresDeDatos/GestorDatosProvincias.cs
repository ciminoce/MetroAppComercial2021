using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Reportes.GestoresDeDatos
{
    public class GestorDatosProvincias
    {
        public static AppComercialDataSet GetDataSet(List<Provincia> lista)
        {
            AppComercialDataSet ds = new AppComercialDataSet();
            foreach (var provincia in lista)
            {
                ds.Tables["Provincias"].Rows.Add(provincia.NombreProvincia);
            }

            return ds;
        }
    }
}
