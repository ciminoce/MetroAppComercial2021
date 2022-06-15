using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Reportes.GestoresDeDatos
{
    public static class GestorDatosBombones
    {
        public static AppComercialDataSet GetDatosListaBombones(List<Bombon> lista)
        {
            AppComercialDataSet ds = new AppComercialDataSet();
            foreach (var bombon in lista)
            {
                ds.Tables["ListaPreciosBombones"].Rows.Add(
                    bombon.NombreProducto,
                    bombon.PrecioVenta,
                    bombon.CantidadEnExistencia,
                    bombon.TipoChocolate.Descripcion
                );
            }

            return ds;

        }
    }
}
