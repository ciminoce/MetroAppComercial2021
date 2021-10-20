using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public abstract class Producto
    {
        public int Id { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int CantidadEnExistencia { get; set; }
        public int CantidadEnPedido { get; set; }
        public int NivelDeReposicion { get; set; }
        public bool Suspendido { get; set; }
        public string Imagen { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
