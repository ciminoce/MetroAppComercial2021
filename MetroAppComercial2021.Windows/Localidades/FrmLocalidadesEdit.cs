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

namespace MetroAppComercial2021.Windows.Localidades
{
    public partial class FrmLocalidadesEdit : MetroFramework.Forms.MetroForm
    {
        public FrmLocalidadesEdit()
        {
            InitializeComponent();
        }

        private Localidad localidad;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombo.CargarDatosComboProvincias(ref ProvinciasMetroComboBox);
            if (provincia!=null)
            {
                ProvinciasMetroComboBox.SelectedValue = provincia.ProvinciaId;
                ProvinciasMetroComboBox.Enabled = false;
            }
            if (localidad!=null)
            {
                LocalidadMetroTextBox.Text = localidad.NombreLocalidad;
                ProvinciasMetroComboBox.SelectedValue = localidad.ProvinciaId;
            }
        }

        public Localidad GetLocalidad()
        {
            return localidad;
        }

        public void SetLocalidad(Localidad localidad)
        {
            this.localidad = localidad;
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (localidad==null)
                {
                    localidad = new Localidad();
                }

                localidad.NombreLocalidad = LocalidadMetroTextBox.Text;
                localidad.Provincia = (Provincia) ProvinciasMetroComboBox.SelectedItem;
                localidad.ProvinciaId =(int) ProvinciasMetroComboBox.SelectedValue;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(LocalidadMetroTextBox.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(LocalidadMetroTextBox,"Debe ingresar una localidad");
            }

            if (ProvinciasMetroComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(ProvinciasMetroComboBox,"Debe seleccionar una provincia");
            }

            return valido;
        }
        private Provincia provincia;
        public void SetProvincia(Provincia provincia)
        {
            this.provincia = provincia;
        }
    }
}
