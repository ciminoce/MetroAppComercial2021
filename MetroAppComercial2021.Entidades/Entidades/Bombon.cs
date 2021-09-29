using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class Bombon:Producto
    {
        public int ChocolateId { get; set; }
        public TipoChocolate TipoChocolate { get; set; }
        public int NuezId { get; set; }
        public TipoNuez TipoNuez { get; set; }
        public int RellenoId { get; set; }
        public TipoRelleno TipoRelleno { get; set; }
    }
}
