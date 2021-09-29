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
using MetroAppComercial2021.Windows.FormClientes;
using MetroAppComercial2021.Windows.Helpers;
using MetroFramework.Forms;

namespace MetroAppComercial2021.Windows.FormProveedores
{
    public partial class FrmProveedores : MetroFramework.Forms.MetroForm
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmProveedoresEdit frm = new FrmProveedoresEdit(_servicio) { Text = "Nuevo Proveedor" };
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IUnitOfWork _unitOfWork;
        private IProveedoresServicios _servicio;
        private List<Proveedor> lista;

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new ProveedoresServicios(_unitOfWork);
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
            foreach (var proveedor in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, proveedor);
                HelperGrid.AgregarFila(DatosMetroGrid, r);
            }
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            {
                if (DatosMetroGrid.SelectedRows.Count == 0)
                {
                    return;
                }

                DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
                var proveedor = (Proveedor)r.Tag;
                FrmProveedoresEdit frm = new FrmProveedoresEdit(_servicio) { Text = "Editar Proveedor" };
                frm.SetProveedor(proveedor);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                try
                {
                    proveedor = frm.GetProveedor();
                    int registrosGuardados = _servicio.Editar(proveedor);
                    if (registrosGuardados == 0)
                    {
                        HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(), "Mensaje",
                            MessageType.Warning);
                        RecargarGrilla();

                        return;
                    }

                    HelperMessageBox.Message(this, GuiMessageManager.RecordsUpdated(registrosGuardados), "Mensaje",
                        MessageType.Information);

                    HelperGrid.SetearFila(r, proveedor);

                }
                catch (Exception exception)
                {
                    HelperMessageBox.Message(this, exception.Message, "Mensaje", MessageType.Error);
                }


            }
        }
    }
}
