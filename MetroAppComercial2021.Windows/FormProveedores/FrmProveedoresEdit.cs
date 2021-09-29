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
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Excepciones;
using MetroAppComercial2021.Windows.Helpers;

namespace MetroAppComercial2021.Windows.FormProveedores
{
    public partial class FrmProveedoresEdit : MetroFramework.Forms.MetroForm
    {
        public FrmProveedoresEdit(IProveedoresServicios servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private IProveedoresServicios _servicio;
        private Proveedor proveedor;
        private Provincia provincia;
        private Localidad localidad;

        private bool esEdicion = false;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombo.CargarDatosComboProvincias(ref ProvinciasMetroComboBox);
            if (proveedor != null)
            {
                esEdicion = true;
                NombreFantasiaMetroTextBox.Text = proveedor.NombreFantasia;
                ApellidoMetroTextBox.Text = proveedor.Apellido;
                NombresMetroTextBox.Text = proveedor.Nombres;
                DireccionMetroTextBox.Text = proveedor.Direccion;
                CodPostalMetroTextBox.Text = proveedor.CodPostal;
                FijoMetroTextBox.Text = proveedor.TelefonoFijo;
                MovilMetroTextBox.Text = proveedor.TelefonoMovil;
                MailMetroTextBox.Text = proveedor.Mail;
                provincia = proveedor.Provincia;
                HelperCombo.CargarDatosComboLocalidades(ref LocalidadMetroComboBox, provincia.ProvinciaId);
                localidad = proveedor.Localidad;
                ProvinciasMetroComboBox.SelectedValue = proveedor.ProvinciaId;
                LocalidadMetroComboBox.SelectedValue = proveedor.LocalidadId;

            }
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ProvinciasMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProvinciasMetroComboBox.SelectedIndex != 0)
            {
                provincia = (Provincia)ProvinciasMetroComboBox.SelectedItem;
                HelperCombo.CargarDatosComboLocalidades(ref LocalidadMetroComboBox, provincia.ProvinciaId);
            }
            else
            {
                provincia = null;
                LocalidadMetroComboBox.DataSource = null;
            }
        }

        private void LocalidadMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LocalidadMetroComboBox.SelectedIndex != 0)
            {
                localidad = (Localidad)LocalidadMetroComboBox.SelectedItem;
            }
            else
            {
                localidad = null;
            }
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (proveedor == null)
                {
                    proveedor = new Proveedor();
                }

                proveedor.NombreFantasia = NombreFantasiaMetroTextBox.Text;
                proveedor.Apellido = ApellidoMetroTextBox.Text;
                proveedor.Nombres = NombresMetroTextBox.Text;
                proveedor.Direccion = DireccionMetroTextBox.Text;
                proveedor.CodPostal = CodPostalMetroTextBox.Text;
                proveedor.TelefonoFijo = FijoMetroTextBox.Text;
                proveedor.TelefonoMovil = MovilMetroTextBox.Text;
                proveedor.Mail = MailMetroTextBox.Text;
                proveedor.Provincia = provincia;
                proveedor.ProvinciaId = provincia.ProvinciaId;
                proveedor.Localidad = localidad;
                proveedor.LocalidadId = localidad.LocalidadId;
                try
                {
                    if (!_servicio.Existe(proveedor))
                    {
                        if (!esEdicion)
                        {
                            int registrosAfectados = _servicio.Agregar(proveedor);
                            if (registrosAfectados == 0)
                            {
                                HelperMessageBox.Message(this, GuiMessageManager.NonRecordsAdded(), "Advertencia",
                                    MessageType.Warning);
                                return;
                            }

                            HelperMessageBox.Message(this, GuiMessageManager.RecordsAdded(registrosAfectados), "Mensaje",
                                MessageType.Information);

                            DialogResult dr =
                                HelperMessageBox.Message(this, "¿Desea agregar otro registro?", "Pregunta");
                            if (dr == DialogResult.Yes)
                            {

                                InicializarControles();
                                NombresMetroTextBox.Focus();

                            }
                            else
                            {
                                DialogResult = DialogResult.OK;
                            }
                        }
                        else
                        {
                            DialogResult = DialogResult.OK;

                        }
                    }
                    else
                    {
                        errorProvider1.SetError(NombresMetroTextBox, GuiMessageManager.ExistingRecord());
                        return;

                    }
                }
                catch (Exception ex)
                {
                    HelperMessageBox.Message(this, ex.Message, "Error", MessageType.Error);
                }
            }
        }

        private void InicializarControles()
        {
            NombreFantasiaMetroTextBox.Clear();
            ApellidoMetroTextBox.Clear();
            NombresMetroTextBox.Clear();
            DireccionMetroTextBox.Clear();
            CodPostalMetroTextBox.Clear();
            FijoMetroTextBox.Clear();
            MovilMetroTextBox.Clear();
            MailMetroTextBox.Clear();
            ProvinciasMetroComboBox.SelectedIndex = 0;

        }

        private bool ValidarDatos()
        {
            //Se deben validar los campos requeridos
            bool valido = true;
            errorProvider1.Clear();

            return valido;
        }

        public Proveedor GetProveedor()
        {
            return proveedor;
        }

        public void SetProveedor(Proveedor proveedor)
        {
            this.proveedor = proveedor;
        }

    }
}
