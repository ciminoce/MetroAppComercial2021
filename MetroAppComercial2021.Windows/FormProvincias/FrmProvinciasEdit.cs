using System;
using System.Windows.Forms;
using MetroAppComercial2021.Entidades.Entidades;

namespace MetroAppComercial2021.Windows.FormProvincias
{
    public partial class FrmProvinciasEdit : MetroFramework.Forms.MetroForm
    {
        public FrmProvinciasEdit()
        {
            InitializeComponent();
        }

        private Provincia provincia;
        public Provincia GetProvincia()
        {
            return provincia;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (provincia!=null)
            {
                ProvinciaMetroTextBox.Text = provincia.NombreProvincia;
            }
        }

        public void SetProvincia(Provincia provincia)
        {
            this.provincia = provincia;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (provincia == null)
                {
                    provincia = new Provincia();
                }

                provincia.NombreProvincia = ProvinciaMetroTextBox.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(ProvinciaMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(ProvinciaMetroTextBox, "Debe ingresar una descripción");
            }
            return valido;
        }

    }
}
