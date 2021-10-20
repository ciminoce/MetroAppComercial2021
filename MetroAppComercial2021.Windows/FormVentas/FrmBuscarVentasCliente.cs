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
    public partial class FrmBuscarVentasCliente : MetroFramework.Forms.MetroForm
    {
        public FrmBuscarVentasCliente()
        {
            InitializeComponent();
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmBuscarVentasCliente_Load(object sender, EventArgs e)
        {
            HelperCombo.CargarDatosComboClientes(ref ClientesMetroComboBox);
        }

        private Cliente cliente;
        public Cliente GetCliente()
        {
            return cliente;
        }

        private void ClientesMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientesMetroComboBox.SelectedIndex>0)
            {
                cliente = (Cliente) ClientesMetroComboBox.SelectedItem;
            }
            else
            {
                cliente = null;
            }
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool esValido = true;
            errorProvider1.Clear();
            if (ClientesMetroComboBox.SelectedIndex==0)
            {
                esValido = false;
                errorProvider1.SetError(ClientesMetroComboBox,"Debe seleccionar un cliente");
            }

            return esValido;
        }
    }
}
