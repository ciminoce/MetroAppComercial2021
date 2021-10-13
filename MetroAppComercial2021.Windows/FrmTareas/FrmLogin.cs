using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroAppComercial2021.Datos.Comun.Repositorios;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Datos.Sql.UnitOfWork;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios;
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Helpers;
using MetroFramework.Forms;

namespace MetroAppComercial2021.Windows.FrmTareas
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {
        private Usuario usuario;
        public FrmLogin()
        {
            InitializeComponent();

        }

        private IUsuariosServicios _servicio;
        private IUnitOfWork _unitOfWork;
        private Empleado empleado;
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new UsuariosServicios(_unitOfWork);
            HelperCombo.CargarDatosComboEmpleados(ref EmpleadosMetroComboBox);
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                //TODO:Encriptar la password
                usuario = _servicio.GetUsuario(empleado.Id, ClaveMetroTextBox.Text);
                if (usuario==null)
                {
                    errorProvider1.SetError(ClaveMetroTextBox,"Clave mal ingresada!!!");
                    return;
                }

                this.Hide();
                FrmPrincipal frm = new FrmPrincipal();
                frm.SetUsuario(usuario);//TODO:Ver la forma de mostrar el usuario en los demás forms
                DialogResult dr=frm.ShowDialog(this);
                this.EmpleadosMetroComboBox.SelectedIndex = 0;
                ClaveMetroTextBox.Clear();
                this.Show();
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (EmpleadosMetroComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(EmpleadosMetroComboBox, "Debe seleccionar un empleado");
            }

            if (string.IsNullOrEmpty(ClaveMetroTextBox.Text))
            {
                valido = false;
                errorProvider1.SetError(ClaveMetroTextBox,"Debe ingresar una clave");
            }

            return valido;
        }

        public Usuario GetUsuario()
        {
            return usuario;
        }

        private void EmpleadosMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmpleadosMetroComboBox.SelectedIndex>0)
            {
                empleado = (Empleado) EmpleadosMetroComboBox.SelectedItem;
            }
            else
            {
                empleado = null;
            }
        }
    }
}
