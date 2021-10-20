using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Datos.Sql.UnitOfWork;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios;
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Excepciones;
using MetroAppComercial2021.Windows.FrmEmpleados;
using MetroAppComercial2021.Windows.Helpers;

namespace MetroAppComercial2021.Windows.FormEmpleados
{
    public partial class FrmEmpleados : MetroFramework.Forms.MetroForm
    {
        public FrmEmpleados()
        {
            InitializeComponent();
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmEmpleadosEdit frm = new FrmEmpleadosEdit(_servicio) {Text = "Nuevo Empleado"};
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IUnitOfWork _unitOfWork;
        private IEmpleadosServicios _servicio;
        private List<Empleado> lista;

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new EmpleadosServicios(_unitOfWork);
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
            foreach (var empleado in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, empleado);
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
                var empleado = (Empleado) r.Tag;
                FrmEmpleadosEdit frm = new FrmEmpleadosEdit(_servicio) {Text = "Editar Empleado"};
                frm.SetEmpleado(empleado);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }

                try
                {
                    empleado = frm.GetEmpleado();
                    int registrosGuardados = _servicio.Editar(empleado);
                    if (registrosGuardados == 0)
                    {
                        HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(), "Mensaje",
                            MessageType.Warning);
                        RecargarGrilla();

                        return;
                    }

                    HelperMessageBox.Message(this, GuiMessageManager.RecordsUpdated(registrosGuardados), "Mensaje",
                        MessageType.Information);

                    HelperGrid.SetearFila(r, empleado);

                }
                catch (Exception exception)
                {
                    HelperMessageBox.Message(this, exception.Message, "Mensaje", MessageType.Error);
                }


            }
        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
            var empleado = (Empleado) r.Tag;
            DialogResult dr = HelperMessageBox.Message(this, GuiMessageManager.ConfirmDelete(), "Confirmar");

            if (dr == DialogResult.Yes)
            {
                try
                {

                    if (!_servicio.EstaRelacionado(empleado))
                    {
                        int registrosBorrados = _servicio.Borrar(empleado);
                        if (registrosBorrados == 0)
                        {
                            HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(),
                                "Advertencia", MessageType.Warning);
                            RecargarGrilla();
                            return;

                        }

                        HelperMessageBox.Message(this, GuiMessageManager.RecordsDeleted(registrosBorrados), "Mensaje",
                            MessageType.Information);

                        HelperGrid.QuitarFila(DatosMetroGrid, r);

                    }
                    else
                    {
                        HelperMessageBox.Message(this, GuiMessageManager.RelatedRecords(), "Error", MessageType.Error);
                    }

                }
                catch (Exception ex)
                {
                    HelperMessageBox.Message(this, ex.Message, "Error", MessageType.Error);
                }

            }

        }
    }
}
