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
using MetroAppComercial2021.Windows.FormChocolates;
using MetroAppComercial2021.Windows.Helpers;

namespace MetroAppComercial2021.Windows.FormNueces
{
    public partial class FrmNueces : MetroFramework.Forms.MetroForm
    {
        public FrmNueces()
        {
            InitializeComponent();
        }

        private IUnitOfWork _unitOfWork;
        private INuecesServicios _servicio;
        private List<TipoNuez> lista;
        private void FrmNueces_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new NuecesServicios(_unitOfWork);
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
            foreach (var nuez in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, nuez);
                HelperGrid.AgregarFila(DatosMetroGrid, r);
            }
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmNuecesEdit frm = new FrmNuecesEdit();
            frm.Text = "Agregar Nueva Nuez";
            DialogResult dr = frm.ShowDialog(this);
            if (dr != DialogResult.OK) return;
            try
            {
                TipoNuez tipoNuez = frm.GetNuez();
                if (_servicio.Existe(tipoNuez))
                {
                    HelperMessageBox.Message(this, GuiMessageManager.ExistingRecord(), "Error", MessageType.Error);
                    return;
                }

                int registrosAgregados = _servicio.Agregar(tipoNuez);
                if (registrosAgregados == 0)
                {
                    HelperMessageBox.Message(this, GuiMessageManager.NonRecordsAdded(), "Advertencia",
                        MessageType.Warning);
                    return;
                }

                HelperMessageBox.Message(this, GuiMessageManager.RecordsAdded(registrosAgregados), "Mensaje",
                    MessageType.Information);

                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, tipoNuez);
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
            var tipoNuez = (TipoNuez)r.Tag;
            DialogResult dr = HelperMessageBox.Message(this, GuiMessageManager.ConfirmDelete(), "Confirmar");

            if (dr == DialogResult.Yes)
            {
                try
                {

                    if (!_servicio.EstaRelacionado(tipoNuez))
                    {
                        int registrosBorrados = _servicio.Borrar(tipoNuez);
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
            var tipoNuez = (TipoNuez)r.Tag;
            FrmNuecesEdit frm = new FrmNuecesEdit() { Text = "Editar Chocolate" };
            frm.SetNuez(tipoNuez);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                tipoNuez = frm.GetNuez();


                if (_servicio.Existe(tipoNuez))
                {

                    HelperMessageBox.Message(this, GuiMessageManager.ExistingRecord(), "Error", MessageType.Error);
                    return;
                }

                int registrosGuardados = _servicio.Editar(tipoNuez);
                if (registrosGuardados == 0)
                {
                    HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(), "Mensaje",
                        MessageType.Warning);
                    RecargarGrilla();

                    return;
                }

                HelperMessageBox.Message(this, GuiMessageManager.RecordsUpdated(registrosGuardados), "Mensaje", MessageType.Information);

                HelperGrid.SetearFila(r, tipoNuez);

            }
            catch (Exception exception)
            {
                HelperMessageBox.Message(this, exception.Message, "Mensaje", MessageType.Error);
            }

        }
    }
}
