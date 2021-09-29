using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroAppComercial2021.Windows.FormBombones;
using MetroAppComercial2021.Windows.FormCajas;
using MetroAppComercial2021.Windows.FormChocolates;
using MetroAppComercial2021.Windows.FormClientes;
using MetroAppComercial2021.Windows.FormNueces;
using MetroAppComercial2021.Windows.FormProveedores;
using MetroAppComercial2021.Windows.FormRellenos;
using MetroAppComercial2021.Windows.FormProvincias;
using MetroAppComercial2021.Windows.Localidades;

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
            Close();
        }

        private void RellenosMetroTile_Click(object sender, EventArgs e)
        {
            FrmRellenos frm = new FrmRellenos();
            frm.ShowDialog(this);
        }

        private void ChocolatesMetroTile_Click(object sender, EventArgs e)
        {
            FrmChocolates frm = new FrmChocolates();
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
    }
}
