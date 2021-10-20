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
using MetroAppComercial2021.Windows.FormBombones;
using MetroAppComercial2021.Windows.FormCajas;
using MetroAppComercial2021.Windows.FormChocolates;
using MetroAppComercial2021.Windows.FormClientes;
using MetroAppComercial2021.Windows.FormNueces;
using MetroAppComercial2021.Windows.FormProveedores;
using MetroAppComercial2021.Windows.FormRellenos;
using MetroAppComercial2021.Windows.FormProvincias;
using MetroAppComercial2021.Windows.FormRoles;
using MetroAppComercial2021.Windows.FormVentas;
using MetroAppComercial2021.Windows.FrmTareas;
using MetroAppComercial2021.Windows.Localidades;
using MetroFramework.Controls;

namespace MetroAppComercial2021.Windows
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void SalirMetroButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RellenosMetroTile_Click(object sender, EventArgs e)
        {
            FrmRellenos frm = new FrmRellenos();
            frm.SetUsuario(usuario);
            frm.ShowDialog(this);
        }

        private void ChocolatesMetroTile_Click(object sender, EventArgs e)
        {
            FrmChocolates frm = new FrmChocolates();
            frm.SetUsuario(usuario);
            frm.ShowDialog(this);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            FrmNueces frm = new FrmNueces();
            frm.ShowDialog(this);
        }

        private void ProvinciasMetroTile_Click(object sender, EventArgs e)
        {
            FrmProvincias frm = new FormProvincias.FrmProvincias();
            frm.ShowDialog(this);
        }

        private void NuecesNetroTile_Click(object sender, EventArgs e)
        {
            FrmNueces frm = new FrmNueces();
            frm.ShowDialog(this);
        }

        private void LocalidadesMetroTile_Click(object sender, EventArgs e)
        {
            FrmLocalidades frm = new FrmLocalidades();
            frm.ShowDialog(this);
        }

        private void ClientesMetroTile_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes();
            frm.ShowDialog(this);
        }

        private void ProveedoresMetroTile_Click(object sender, EventArgs e)
        {
            FrmProveedores frm = new FrmProveedores();
            frm.ShowDialog(this);
        }

        private void BombonesMetroTile_Click(object sender, EventArgs e)
        {
            FrmBombones frm = new FrmBombones();
            frm.ShowDialog(this);
        }

        private void CajaMetroTile_Click(object sender, EventArgs e)
        {
            FrmCajas frm = new FrmCajas();
            frm.ShowDialog(this);

        }

        private void EmpmleadosMetroTile_Click(object sender, EventArgs e)
        {
            FormEmpleados.FrmEmpleados frm = new FormEmpleados.FrmEmpleados();
            frm.ShowDialog(this);
        }

        private Usuario usuario;
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            VerificarPermisos();
        }

        private void VerificarPermisos()
        {
            //Si el usuario es administrador 
            //no chequeo nada y me voy
            if (usuario.Rol.NombreRol=="Administrador")
            {
                return;
            }

            foreach (var control in this.Controls)
            {
                if (control is MetroTile)
                {
                    string opcionTile =(string) ((MetroTile)control).Tag;
                    ((MetroTile)control).Enabled = usuario.TienePermiso(opcionTile);
                }
            }

        }

        private void RolesMetroTile_Click(object sender, EventArgs e)
        {
            FrmRoles frm = new FrmRoles();
            frm.ShowDialog(this);
        }

        private void UsuariosMetroTile_Click(object sender, EventArgs e)
        {
            FrmUsuarios.FrmUsuarios frm = new FrmUsuarios.FrmUsuarios();
            frm.ShowDialog(this);
        }

        public void SetUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        private void VentasMetroTile_Click(object sender, EventArgs e)
        {
            FrmVentas frm = new FrmVentas();
            frm.SetUsuario(usuario);
            frm.ShowDialog(this);
        }
    }
}
