using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Reportes;

namespace MetroAppComercial2021.Windows.FormBombones
{
    public partial class FrmOpcionesListadoBombones : MetroFramework.Forms.MetroForm
    {
        public FrmOpcionesListadoBombones()
        {
            InitializeComponent();
        }

        private ReportClass rpt;
        private void ListarMetroButton_Click(object sender, EventArgs e)
        {
            if (MenorMetroRadioButton.Checked)
            {
                lista = lista.OrderBy(o => o.PrecioVenta).ToList();
            }
            else
            {
                lista = lista.OrderByDescending(o => o.PrecioVenta).ToList();
            }

            if (AgrupadoMetroCheckBox.Checked)
            {
                rpt = ManejadorDeReportes.GetListaPreciosBombonesAgrupadosPorChocolate(lista);
            }
            else
            {
                rpt = ManejadorDeReportes.GetListaPrecioBombones(lista);

            }

            FrmVisorReportes frm = new FrmVisorReportes();
            frm.SetReporte(rpt);
            frm.ShowDialog(this);
        }

        private List<Bombon> lista;
        public void SetListaBombones(List<Bombon> lista)
        {
            this.lista = lista;
        }
    }
}
