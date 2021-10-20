using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class DetalleVenta
    {
        public int DetalleVentaId { get; set; }
        public int VentaId { get; set; }
        public int ProductoId { get; set; }
        public TipoProducto TipoProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public Producto Producto { get; set; }

        public byte[] RowVersion { get; set; }

    }
}
