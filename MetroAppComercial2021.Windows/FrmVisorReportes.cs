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
using MetroAppComercial2021.Reportes.Reportes.Provincias;

namespace MetroAppComercial2021.Windows
{
    public partial class FrmVisorReportes : MetroFramework.Forms.MetroForm
    {
        public FrmVisorReportes()
        {
            InitializeComponent();
        }

        private ReportClass rpt;

        public void SetReporte(ReportClass rpt)
        {
            this.rpt = rpt;
        }
        private void CancelarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmVisorReportes_Load(object sender, EventArgs e)
        {
            if (rpt==null)
            {
                return;
            }

            crv.ReportSource = rpt;
            crv.Show();
            
        }
    }
}
