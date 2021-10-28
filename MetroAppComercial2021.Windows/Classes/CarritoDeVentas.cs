using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Windows.Classes
{
    public class CarritoDeVentas
    {
        private List<DetalleVenta> listaDeDetalles;

        public static CarritoDeVentas instancia = null;

        public static CarritoDeVentas GetInstancia()
        {
            if (instancia == null)
            {
                instancia = new CarritoDeVentas();
            }

            return instancia;
        }

        private CarritoDeVentas()
        {
            listaDeDetalles = new List<DetalleVenta>();
        }

        public void Agregar(DetalleVenta detalleVta)
        {
            var item = listaDeDetalles.SingleOrDefault(d => d.ProductoId == detalleVta.ProductoId &&
                                                            d.TipoProducto == detalleVta.TipoProducto);
            if (item==null)
            {
                listaDeDetalles.Add(detalleVta);
                
            }
            else
            {
                item.Cantidad += detalleVta.Cantidad;
            }
        }

        public void Quitar(DetalleVenta detalleVta)
        {
            listaDeDetalles.Remove(detalleVta);
        }

        public int GetCantidad()
        {
            return listaDeDetalles.Count;
        }

        public List<DetalleVenta> GetLista()
        {
            return listaDeDetalles;
        }

        public void SetDetalles(List<DetalleVenta> detalle)
        {
            listaDeDetalles = detalle;
        }

        public bool Existe(DetalleVenta detalleVta)
        {
            return listaDeDetalles.Any(d => d.ProductoId == detalleVta.ProductoId &&
                                            d.TipoProducto == detalleVta.TipoProducto);
        }



        public decimal GetTotal()
        {
            return listaDeDetalles.Sum(d => d.Precio * d.Cantidad);
        }

    }
}
