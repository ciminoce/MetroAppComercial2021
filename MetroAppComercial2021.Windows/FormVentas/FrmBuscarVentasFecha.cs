using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetroAppComercial2021.Windows.FormVentas
{
    public partial class FrmBuscarVentasFecha : MetroFramework.Forms.MetroForm
    {
        public FrmBuscarVentasFecha()
        {
            InitializeComponent();
        }

        private DateTime fecha;
        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                fecha = FechaMetroDateTime.Value.Date;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (fecha>DateTime.Now.Date)
            {
                esValido = false;
                errorProvider1.SetError(FechaMetroDateTime,"Fecha superior a la fecha actual");
            }

            return esValido;
        }

        public DateTime GetFecha()
        {
            return fecha;
        }
    }
}
