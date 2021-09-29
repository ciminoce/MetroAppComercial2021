using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Datos.Sql.UnitOfWork;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios;
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Excepciones;
using MetroAppComercial2021.Windows.Helpers;

namespace MetroAppComercial2021.Windows.FormProvincias
{
    public partial class FrmProvincias : MetroFramework.Forms.MetroForm
    {
        public FrmProvincias()
        {
            InitializeComponent();
        }
        private IUnitOfWork _unitOfWork;
        private IProvinciasServicios _servicio;
        private List<Provincia> lista;
        private void FrmProvincias_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new ProvinciasServicios(_unitOfWork);
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
            foreach (var provincia in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, provincia);
                HelperGrid.AgregarFila(DatosMetroGrid, r);
            }
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmProvinciasEdit frm = new FrmProvinciasEdit();
            frm.Text = "Agregar Nueva Provincia";
            DialogResult dr = frm.ShowDialog(this);
            if (dr != DialogResult.OK) return;
            try
            {
                Provincia provincia = frm.GetProvincia();
                if (_servicio.Existe(provincia))
                {
                    HelperMessageBox.Message(this, GuiMessageManager.ExistingRecord(), "Error", MessageType.Error);
                    return;
                }

                int registrosAgregados = _servicio.Agregar(provincia);
                if (registrosAgregados == 0)
                {
                    HelperMessageBox.Message(this, GuiMessageManager.NonRecordsAdded(), "Advertencia",
                        MessageType.Warning);
                    return;
                }

                HelperMessageBox.Message(this, GuiMessageManager.RecordsAdded(registrosAgregados), "Mensaje",
                    MessageType.Information);

                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, provincia);
                HelperGrid.AgregarFila(DatosMetroGrid, r);

            }
            catch (Exception exception)
            {
                HelperMessageBox.Message(this, exception.Message, "Error", MessageType.Error);
            }

        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
            var provincia = (Provincia)r.Tag;
            DialogResult dr = HelperMessageBox.Message(this, GuiMessageManager.ConfirmDelete(), "Confirmar");

            if (dr == DialogResult.Yes)
            {
                try
                {

                    if (!_servicio.EstaRelacionado(provincia))
                    {
                        int registrosBorrados = _servicio.Borrar(provincia);
                        if (registrosBorrados == 0)
                        {
                            HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(),
                                "Advertencia", MessageType.Warning);
                            RecargarGrilla();
                            return;

                        }

                        HelperMessageBox.Message(this, GuiMessageManager.RecordsDeleted(registrosBorrados), "Mensaje", MessageType.Information);

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

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
            var provincia = (Provincia)r.Tag;
            FrmProvinciasEdit frm = new FrmProvinciasEdit() { Text = "Editar Provincia" };
            frm.SetProvincia(provincia);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                provincia = frm.GetProvincia();


                if (_servicio.Existe(provincia))
                {

                    HelperMessageBox.Message(this, GuiMessageManager.ExistingRecord(), "Error", MessageType.Error);
                    return;
                }

                int registrosGuardados = _servicio.Editar(provincia);
                if (registrosGuardados == 0)
                {
                    HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(), "Mensaje",
                        MessageType.Warning);
                    RecargarGrilla();

                    return;
                }

                HelperMessageBox.Message(this, GuiMessageManager.RecordsUpdated(registrosGuardados), "Mensaje", MessageType.Information);

                HelperGrid.SetearFila(r, provincia);

            }
            catch (Exception exception)
            {
                HelperMessageBox.Message(this, exception.Message, "Mensaje", MessageType.Error);
            }

        }

    }
}
