using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Windows.Helpers;

namespace MetroAppComercial2021.Windows.FormVentas
{
    public partial class FrmInfoVenta : MetroFramework.Forms.MetroForm
    {
        public FrmInfoVenta()
        {
            InitializeComponent();
        }
        private Venta venta;

        public void SetVenta(Venta venta)
        {
            this.venta = venta;
        }

        private void FrmInfoVenta_Load(object sender, EventArgs e)
        {
            this.Text = $"Detalle de la Venta Nro:{venta.VentaId}";
            ClienteMetroTextBox.Text = venta.Cliente.ApeNombre;
            DireccionMetroTextBox.Text = venta.Cliente.Direccion;
            ProvinciaMetroTextBox.Text = venta.Cliente.Provincia.NombreProvincia;
            LocalidadMetroTextBox.Text = venta.Cliente.Localidad.NombreLocalidad;
            CodPostalMetroTextBox.Text = venta.Cliente.CodPostal;
            FechaMetroTextBox.Text = venta.FechaVenta.ToShortDateString();
            RegaloMetroCheckBox.Checked = venta.Regalo;

            foreach (var ventaDetalle in venta.DetalleVentas)
            {
                var r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, ventaDetalle);
                HelperGrid.AgregarFila(DatosMetroGrid, r);
            }

            TotalAPagarMetroTextBox.Text = venta.DetalleVentas.Sum(dt => dt.Cantidad * dt.Precio).ToString();
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
