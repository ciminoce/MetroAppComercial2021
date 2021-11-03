using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaVenta { get; set; }
        public bool Regalo { get; set; }
        public decimal Total { get; set; }
        public byte[] RowVersion { get; set; }
        public Cliente Cliente { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();
    }
}
