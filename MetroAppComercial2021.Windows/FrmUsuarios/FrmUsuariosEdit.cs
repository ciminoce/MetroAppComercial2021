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

namespace MetroAppComercial2021.Windows.FrmUsuarios
{
    public partial class FrmUsuariosEdit : MetroFramework.Forms.MetroForm
    {
        public FrmUsuariosEdit()
        {
            InitializeComponent();
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public Usuario GetUsuario()
        {
            throw new NotImplementedException();
        }

        public void SetUsuario(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            HelperCombo.CargarDatosComboEmpleados(ref EmpleadosMetroComboBox);
            HelperCombo.CargarDatosComboRoles(ref RolesMetroComboBox);
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            //TODO:Encriptar la password del usuario
        }
    }
}
