using MetroAppComercial2021.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroAppComercial2021.Servicios.Facades;

namespace MetroAppComercial2021.Windows.FormCajas
{
    public partial class FrmCajasEdit : MetroFramework.Forms.MetroForm
    {
        public FrmCajasEdit(ICajasServicios servicio)
        {
            InitializeComponent();
            _servicio = servicio;
        }

        private readonly ICajasServicios _servicio;
        internal void SetCaja(Caja caja)
        {
            throw new NotImplementedException();
        }

        public Caja GetCaja()
        {
            throw new NotImplementedException();
        }
    }
}
