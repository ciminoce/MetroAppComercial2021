using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Reportes.GestoresDeDatos
{
    public static class GestorDatosVentas
    {
        public static AppComercialDataSet GetDataSet(Venta venta)
        {
            AppComercialDataSet ds = new AppComercialDataSet();
            ds.Tables["Venta"].Rows.Add(venta.VentaId, venta.Cliente.ApeNombre, venta.FechaVenta);
            foreach (var detalleVenta in venta.DetalleVentas)
            {
                ds.Tables["DetalleVenta"].Rows.Add(detalleVenta.Cantidad, detalleVenta.Producto.NombreProducto,
                    detalleVenta.TipoProducto,
                    detalleVenta.Precio, detalleVenta.Cantidad * detalleVenta.Precio);
            }

            return ds;
        }
    }
}
