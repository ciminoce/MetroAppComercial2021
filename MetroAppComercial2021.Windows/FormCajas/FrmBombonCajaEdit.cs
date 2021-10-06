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

namespace MetroAppComercial2021.Windows.FormCajas
{
    public partial class FrmBombonCajaEdit : MetroFramework.Forms.MetroForm
    {
        public FrmBombonCajaEdit()
        {
            InitializeComponent();
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private Bombon bombon;
        private DetalleCaja detalleCaja;
        private void FrmBombonCajaEdit_Load(object sender, EventArgs e)
        {
            HelperCombo.CargarDatosComboBombones(ref BombonesMetroComboBox);
        }

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                detalleCaja = new DetalleCaja()
                {
                    BombonId = bombon.Id,
                    Bombon = bombon,
                    Cantidad = (int) UnidadesNumericUpDown.Value
                };

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (BombonesMetroComboBox.SelectedIndex==0)
            {
                valido = false;
                errorProvider1.SetError(BombonesMetroComboBox,"Debe seleccionar un bombón");
            }else if (bombon.Suspendido)
            {
                valido = false;
                errorProvider1.SetError(BombonesMetroComboBox,"Bombón suspendido!!!!");
            }else if (bombon.CantidadEnExistencia<(int)UnidadesNumericUpDown.Value)
            {
                valido = false;
                errorProvider1.SetError(UnidadesNumericUpDown,"Stock insuficiente!!!");
            }

            return valido;

        }

        private void BombonesMetroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BombonesMetroComboBox.SelectedIndex>0)
            {
                bombon = (Bombon) BombonesMetroComboBox.SelectedItem;
            }
            else
            {
                bombon = null;
            }
        }

        public DetalleCaja GetDetalleCaja()
        {
            return detalleCaja;
        }
    }
}
