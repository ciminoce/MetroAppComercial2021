using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroAppComercial2021.Datos.Comun.Excepciones;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Excepciones;
using MetroAppComercial2021.Windows.Helpers;

namespace MetroAppComercial2021.Windows.FormClientes
{
    public partial class FrmClientesEdit : MetroFramework.Forms.MetroForm
    {
        public FrmClientesEdit(IClientesServicios servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private IClientesServicios _servicio;
        private Cliente cliente;
        private Provincia provincia;
        private Localidad localidad;

        private bool esEdicion = false;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombo.CargarDatosComboProvincias(ref ProvinciasMetroComboBox);
            if (cliente != null)
            {
                esEdicion = true;
                ApellidoMetroTextBox.Text = cliente.Apellido;
                NombresMetroTextBox.Text = cliente.Nombres;
                DireccionMetroTextBox.Text = cliente.Direccion;
                CodPostalMetroTextBox.Text = cliente.CodPostal;
                FijoMetroTextBox.Text = cliente.TelefonoFijo;
                MovilMetroTextBox.Text = cliente.TelefonoMovil;
                MailMetroTextBox.Text = cliente.Mail;
                provincia = cliente.Provincia;
                HelperCombo.CargarDatosComboLocalidades(ref LocalidadMetroComboBox, provincia.ProvinciaId);
                localidad = cliente.Localidad;
                ProvinciasMetroComboBox.SelectedValue =cliente.ProvinciaId;
                LocalidadMetroComboBox.SelectedValue = cliente.LocalidadId;

            }
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ProvinciasMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProvinciasMetroComboBox.SelectedIndex!=0)
            {
                provincia = (Provincia) ProvinciasMetroComboBox.SelectedItem;
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
            if (LocalidadMetroComboBox.SelectedIndex!=0)
            {
                localidad = (Localidad) LocalidadMetroComboBox.SelectedItem;
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
                if (cliente==null)
                {
                    cliente = new Cliente();
                }

                cliente.Apellido = ApellidoMetroTextBox.Text;
                cliente.Nombres = NombresMetroTextBox.Text;
                cliente.Direccion = DireccionMetroTextBox.Text;
                cliente.CodPostal = CodPostalMetroTextBox.Text;
                cliente.TelefonoFijo = FijoMetroTextBox.Text;
                cliente.TelefonoMovil = MovilMetroTextBox.Text;
                cliente.Mail = MailMetroTextBox.Text;
                cliente.Provincia = provincia;
                cliente.ProvinciaId = provincia.ProvinciaId;
                cliente.Localidad = localidad;
                cliente.LocalidadId = localidad.LocalidadId;
                try
                {
                    if (!_servicio.Existe(cliente))
                    {
                        if (!esEdicion)
                        {
                            int registrosAfectados = _servicio.Agregar(cliente);
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
                            if (dr==DialogResult.Yes)
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

        public Cliente GetCliente()
        {
            return cliente;
        }

        public void SetCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }
    }
}
