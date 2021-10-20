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

namespace MetroAppComercial2021.Windows.FrmEmpleados
{
    public partial class FrmEmpleadosEdit : MetroFramework.Forms.MetroForm
    {
        public FrmEmpleadosEdit(IEmpleadosServicios servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }
        private IEmpleadosServicios _servicio;
        private Empleado empleado;
        private Provincia provincia;
        private Localidad localidad;

        private bool esEdicion = false;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombo.CargarDatosComboProvincias(ref ProvinciasMetroComboBox);
            if (empleado != null)
            {
                esEdicion = true;
                ApellidoMetroTextBox.Text = empleado.Apellido;
                NombresMetroTextBox.Text = empleado.Nombres;
                FecNacMetroDateTime.Value = empleado.FechaNacimiento;
                ContratacionMetroDateTime.Value = empleado.FechaContratacion;
                DireccionMetroTextBox.Text = empleado.Direccion;
                CodPostalMetroTextBox.Text = empleado.CodPostal;
                FijoMetroTextBox.Text = empleado.TelefonoFijo;
                MovilMetroTextBox.Text = empleado.TelefonoMovil;
                MailMetroTextBox.Text = empleado.Mail;
                provincia = empleado.Provincia;
                HelperCombo.CargarDatosComboLocalidades(ref LocalidadMetroComboBox, provincia.ProvinciaId);
                localidad = empleado.Localidad;
                ProvinciasMetroComboBox.SelectedValue = empleado.ProvinciaId;
                LocalidadMetroComboBox.SelectedValue = empleado.LocalidadId;
                ActivoMetroCheckBox.Checked = empleado.Activo;
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
                if (empleado == null)
                {
                    empleado = new Empleado();
                }

                empleado.Apellido = ApellidoMetroTextBox.Text;
                empleado.Nombres = NombresMetroTextBox.Text;
                empleado.FechaNacimiento = FecNacMetroDateTime.Value;
                empleado.FechaContratacion = ContratacionMetroDateTime.Value;
                empleado.Direccion = DireccionMetroTextBox.Text;
                empleado.CodPostal = CodPostalMetroTextBox.Text;
                empleado.TelefonoFijo = FijoMetroTextBox.Text;
                empleado.TelefonoMovil = MovilMetroTextBox.Text;
                empleado.Mail = MailMetroTextBox.Text;
                empleado.Provincia = provincia;
                empleado.ProvinciaId = provincia.ProvinciaId;
                empleado.Localidad = localidad;
                empleado.LocalidadId = localidad.LocalidadId;
                empleado.Activo = ActivoMetroCheckBox.Checked;
                try
                {
                    if (!_servicio.Existe(empleado))
                    {
                        if (!esEdicion)
                        {
                            int registrosAfectados = _servicio.Agregar(empleado);
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
            ApellidoMetroTextBox.Clear();
            NombresMetroTextBox.Clear();
            DireccionMetroTextBox.Clear();
            CodPostalMetroTextBox.Clear();
            FijoMetroTextBox.Clear();
            MovilMetroTextBox.Clear();
            MailMetroTextBox.Clear();
            ProvinciasMetroComboBox.SelectedIndex = 0;
            ActivoMetroCheckBox.Checked = true;
            FecNacMetroDateTime.Value=DateTime.Today;
            ContratacionMetroDateTime.Value=DateTime.Today;
            
        }

        private bool ValidarDatos()
        {
            //Se deben validar los campos requeridos
            bool valido = true;
            errorProvider1.Clear();

            return valido;
        }

        public Empleado GetEmpleado()
        {
            return empleado;
        }

        public void SetEmpleado(Empleado empleado)
        {
            this.empleado = empleado;
        }

    }
}
