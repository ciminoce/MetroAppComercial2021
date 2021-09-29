using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class Caja:Producto
    {
        public List<DetalleCaja> DetalleCajas { get; set; } = new List<DetalleCaja>();
    }
}
