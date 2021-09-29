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

namespace MetroAppComercial2021.Windows.FormRellenos
{
    public partial class FrmRellenosEdit : MetroFramework.Forms.MetroForm
    {
        public FrmRellenosEdit()
        {
            InitializeComponent();
        }
        private TipoRelleno tipoRelleno;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoRelleno != null)
            {
                RellenoMetroTextBox.Text = tipoRelleno.Descripcion;
            }
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoRelleno == null)
                {
                    tipoRelleno = new TipoRelleno();
                }

                tipoRelleno.Descripcion = RellenoMetroTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(RellenoMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(RellenoMetroTextBox, "Debe ingresar una descripción");
            }

            if (!RellenoMetroTextBox.Text.Replace(" ", "").All(Char.IsLetter))
            {
                valido = false;
                errorProvider1.SetError(RellenoMetroTextBox, "La descripción contiene caracteres no válidos");
            }

            return valido;
        }

        public TipoRelleno GetRelleno()
        {
            return tipoRelleno;
        }

        public void SetRelleno(TipoRelleno tipoRelleno)
        {
            this.tipoRelleno = tipoRelleno;
        }

    }
}
