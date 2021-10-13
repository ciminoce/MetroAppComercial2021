using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Datos.Sql.UnitOfWork;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios;
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Excepciones;
using MetroAppComercial2021.Windows.Helpers;
using MetroAppComercial2021.Windows.Localidades;

namespace MetroAppComercial2021.Windows.FormRoles
{
    public partial class FrmRoles : MetroFramework.Forms.MetroForm
    {
        public FrmRoles()
        {
            InitializeComponent();
        }
        private IUnitOfWork _unitOfWork;
        private IRolesServicios _servicio;
        private List<Rol> lista;
        private void FrmRoles_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new RolesServicios(_unitOfWork);
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                lista = _servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception e)
            {
                HelperMessageBox.Message(this, e.Message, "Error", MessageType.Error);
            }
        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosMetroGrid);
            foreach (var rol in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, rol);
                HelperGrid.AgregarFila(DatosMetroGrid, r);
            }
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();

        }

    }
}
