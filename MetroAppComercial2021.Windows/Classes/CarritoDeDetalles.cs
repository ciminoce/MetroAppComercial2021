using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Windows.Classes
{
    //Maneja los detalles de las cajas en memoria
    public class CarritoDeDetalles
    {
        private List<DetalleCaja> listaDeDetalles;

        public static CarritoDeDetalles instancia = null;

        public static CarritoDeDetalles GetInstancia()
        {
            if (instancia==null)
            {
                instancia = new CarritoDeDetalles();
            }

            return instancia;
        }

        private CarritoDeDetalles()
        {
            listaDeDetalles = new List<DetalleCaja>();
        }

        public void Agregar(DetalleCaja detalleCaja)
        {
            listaDeDetalles.Add(detalleCaja);
        }

        public void Quitar(DetalleCaja detalleCaja)
        {
            listaDeDetalles.Remove(detalleCaja);
        }

        public int GetCantidad()
        {
            return listaDeDetalles.Count;
        }

        public List<DetalleCaja> GetLista()
        {
            return listaDeDetalles;
        }

        public void SetDetalles(List<DetalleCaja> detalle)
        {
            listaDeDetalles = detalle;
        }

        public bool Existe(DetalleCaja detalleCaja)
        {
            return listaDeDetalles.Contains(detalleCaja);
        }

        public void Actualizar(DetalleCaja detalleCaja)
        {
            var detalle = listaDeDetalles.SingleOrDefault(d => d.BombonId == detalleCaja.BombonId);
            detalle.Cantidad += detalleCaja.Cantidad;
        }

        public decimal GetPrecioCosto()
        {
            return listaDeDetalles.Sum(d => d.Bombon.PrecioCosto * d.Cantidad);
        }

        public decimal GetPrecioVenta()
        {
            return listaDeDetalles.Sum(d => d.Bombon.PrecioVenta * d.Cantidad);
        }
    }
}
