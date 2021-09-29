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

namespace MetroAppComercial2021.Windows.FormNueces
{
    public partial class FrmNuecesEdit : MetroFramework.Forms.MetroForm
    {
        public FrmNuecesEdit()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoNuez!=null)
            {
                NuezMetroTextBox.Text = tipoNuez.Descripcion;
            }
        }

        public TipoNuez GetNuez()
        {
            return tipoNuez;
        }

        private TipoNuez tipoNuez;
        public void SetNuez(TipoNuez tipoNuez)
        {
            this.tipoNuez = tipoNuez;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoNuez == null)
                {
                    tipoNuez = new TipoNuez();
                }

                tipoNuez.Descripcion = NuezMetroTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(NuezMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(NuezMetroTextBox, "Debe ingresar una descripción");
            }

            if (!NuezMetroTextBox.Text.Replace(" ", "").All(Char.IsLetter))
            {
                valido = false;
                errorProvider1.SetError(NuezMetroTextBox, "La descripción contiene caracteres no válidos");
            }

            return valido;
        }
    }
}
