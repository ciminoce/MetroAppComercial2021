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

namespace MetroAppComercial2021.Windows.FormChocolates
{
    public partial class FrmChocolatesEdit : MetroFramework.Forms.MetroForm
    {
        public FrmChocolatesEdit()
        {
            InitializeComponent();
        }

        private TipoChocolate tipoChocolate;
        public void SetChocolate(TipoChocolate tipoChocolate)
        {
            this.tipoChocolate = tipoChocolate;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (tipoChocolate!=null)
            {
                ChocolateMetroTextBox.Text = tipoChocolate.Descripcion;
            }
        }

        public TipoChocolate GetChocolate()
        {
            return tipoChocolate;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (tipoChocolate == null)
                {
                    tipoChocolate = new TipoChocolate();
                }

                tipoChocolate.Descripcion = ChocolateMetroTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ChocolateMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(ChocolateMetroTextBox, "Debe ingresar una descripción");
            }

            if (!ChocolateMetroTextBox.Text.Replace(" ", "").All(Char.IsLetter))
            {
                valido = false;
                errorProvider1.SetError(ChocolateMetroTextBox, "La descripción contiene caracteres no válidos");
            }

            return valido;
        }
    }
}
