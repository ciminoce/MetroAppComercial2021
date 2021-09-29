using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetroAppComercial2021.Entidades.Entidades
{
    public class DetalleCaja
    {
        public int DetalleCajaId { get; set; }
        public int CajaId { get; set; }
        public int BombonId { get; set; }
        public Bombon Bombon { get; set; }
        public int Cantidad { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
