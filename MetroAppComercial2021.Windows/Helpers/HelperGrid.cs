using System;
using System.Windows.Forms;
using MetroAppComercial2021.Entidades.Entidades;
using MetroFramework.Controls;

namespace MetroAppComercial2021.Windows.Helpers
{
    public static class HelperGrid
    {
        public static void AgregarFila(MetroGrid dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Add(r);
        }
        public static void SetearFila(DataGridViewRow r, Object obj)
        {
            if (obj is TipoRelleno)
            {
                r.Cells[0].Value = ((TipoRelleno)obj).Descripcion;
            }
            else if (obj is TipoChocolate)
            {
                r.Cells[0].Value = ((TipoChocolate)obj).Descripcion;
            }
            else if (obj is TipoNuez)
            {
                r.Cells[0].Value = ((TipoNuez)obj).Descripcion;
            }
            else if (obj is Provincia)
            {
                r.Cells[0].Value = ((Provincia)obj).NombreProvincia;
            }
            else if (obj is Localidad)
            {
                r.Cells[0].Value = ((Localidad)obj).NombreLocalidad;
                r.Cells[1].Value = ((Localidad)obj).Provincia.NombreProvincia;
            }
            else if (obj is Cliente)
            {
                r.Cells[0].Value = ((Cliente)obj).ToString();
                r.Cells[1].Value = ((Cliente)obj).TelefonoFijo;
                r.Cells[2].Value = ((Cliente)obj).TelefonoMovil;
                r.Cells[3].Value = ((Cliente) obj).Mail;

            }else if (obj is Proveedor)
            {
                r.Cells[0].Value = ((Proveedor)obj).NombreFantasia;
                r.Cells[1].Value = ((Proveedor)obj).ToString();
                r.Cells[2].Value = ((Proveedor)obj).TelefonoFijo;
                r.Cells[3].Value = ((Proveedor)obj).TelefonoMovil;
                r.Cells[4].Value = ((Proveedor)obj).Mail;
               
            }else if (obj is Bombon)
            {
                r.Cells[0].Value = ((Bombon)obj).NombreProducto;
                r.Cells[1].Value = ((Bombon)obj).CantidadEnExistencia;
                r.Cells[2].Value = ((Bombon)obj).PrecioVenta;
                r.Cells[3].Value = ((Bombon)obj).Suspendido;

            }else if (obj is Caja)
            {
                r.Cells[0].Value = ((Caja)obj).NombreProducto;
                r.Cells[1].Value = ((Caja)obj).CantidadEnExistencia;
                r.Cells[2].Value = ((Caja)obj).PrecioVenta;
                r.Cells[3].Value = ((Caja)obj).Suspendido;

            }else if (obj is DetalleCaja)
            {
                r.Cells[0].Value = ((DetalleCaja)obj).Bombon.NombreProducto;
                r.Cells[1].Value = ((DetalleCaja)obj).Cantidad;

            }
            else if (obj is Empleado)
            {
                r.Cells[0].Value = ((Empleado)obj).ToString();
                r.Cells[1].Value = ((Empleado)obj).TelefonoFijo;
                r.Cells[2].Value = ((Empleado)obj).TelefonoMovil;
                r.Cells[3].Value = ((Empleado)obj).Mail;

            }else if (obj is Rol)
            {
                r.Cells[0].Value = ((Rol)obj).NombreRol;

            }else if (obj is Usuario)
            {
                r.Cells[0].Value = ((Usuario)obj).Empleado.ApeNombre;
                r.Cells[1].Value = ((Usuario)obj).Rol.NombreRol;

            }else if (obj is Venta)
            {
                r.Cells[0].Value = ((Venta)obj).VentaId;
                r.Cells[1].Value = ((Venta)obj).Cliente.ApeNombre;
                r.Cells[2].Value = ((Venta)obj).FechaVenta.ToShortDateString();
                r.Cells[3].Value = ((Venta)obj).Regalo;
                r.Cells[4].Value = ((Venta) obj).Total;

            }



            r.Tag = obj;
        }
        public static DataGridViewRow ConstruirFila(DataGridView dataGridView)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dataGridView);
            return r;
        }
        public static void LimpiarGrilla(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        public static void QuitarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }

    }
}
