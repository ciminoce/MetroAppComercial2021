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
using MetroFramework.Forms;

namespace MetroAppComercial2021.Windows.FormCajas
{
    public partial class FrmDetalleCajas : MetroFramework.Forms.MetroForm
    {
        public FrmDetalleCajas()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (caja != null)
            {
                CajaMetroLabel.Text = caja.NombreProducto;
                DescripcionMetroTextBox.Text = caja.Descripcion;
                PVentaMetroLabel.Text = caja.PrecioVenta.ToString();
                CostoMetroLabel.Text = caja.PrecioCosto.ToString();
                ExistenciaMetroLabel.Text = caja.CantidadEnExistencia.ToString();
                EnPedidoMetroLabel.Text = caja.CantidadEnPedido.ToString();
                SuspendidoMetroCheckBox.Checked = caja.Suspendido;

                foreach (var detalleCaja in caja.DetalleCajas)
                {
                    var r = HelperGrid.ConstruirFila(DatosMetroGrid);
                    HelperGrid.SetearFila(r, detalleCaja);
                    HelperGrid.AgregarFila(DatosMetroGrid, r);
                }

            }

        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Caja caja;
        public void SetCaja(Caja caja)
        {
            this.caja = caja;
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
