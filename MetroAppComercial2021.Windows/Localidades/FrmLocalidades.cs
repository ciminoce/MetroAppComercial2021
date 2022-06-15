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
using MetroAppComercial2021.Reportes;
using MetroAppComercial2021.Reportes.Reportes.Ciudades;
using MetroAppComercial2021.Servicios;
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Excepciones;
using MetroAppComercial2021.Windows.FormProvincias;
using MetroAppComercial2021.Windows.Helpers;

namespace MetroAppComercial2021.Windows.Localidades
{
    public partial class FrmLocalidades : MetroFramework.Forms.MetroForm
    {
        public FrmLocalidades()
        {
            InitializeComponent();
        }
        private IUnitOfWork _unitOfWork;
        private ILocalidadesServicios _servicio;
        private List<Localidad> lista;
        private void FrmLocalidades_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new LocalidadesServicios(_unitOfWork);
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
            foreach (var localidad in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, localidad);
                HelperGrid.AgregarFila(DatosMetroGrid, r);
            }
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmLocalidadesEdit frm = new FrmLocalidadesEdit();
            frm.Text = "Agregar Nueva Localidad";
            DialogResult dr = frm.ShowDialog(this);
            if (dr != DialogResult.OK) return;
            try
            {
                Localidad localidad = frm.GetLocalidad();
                if (_servicio.Existe(localidad))
                {
                    HelperMessageBox.Message(this, GuiMessageManager.ExistingRecord(), "Error", MessageType.Error);
                    return;
                }

                int registrosAgregados = _servicio.Agregar(localidad);
                if (registrosAgregados == 0)
                {
                    HelperMessageBox.Message(this, GuiMessageManager.NonRecordsAdded(), "Advertencia",
                        MessageType.Warning);
                    return;
                }

                HelperMessageBox.Message(this, GuiMessageManager.RecordsAdded(registrosAgregados), "Mensaje",
                    MessageType.Information);

                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, localidad);
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
            var localidad = (Localidad)r.Tag;
            DialogResult dr = HelperMessageBox.Message(this, GuiMessageManager.ConfirmDelete(), "Confirmar");

            if (dr == DialogResult.Yes)
            {
                try
                {

                    if (!_servicio.EstaRelacionado(localidad))
                    {
                        int registrosBorrados = _servicio.Borrar(localidad);
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
            var localidad = (Localidad)r.Tag;
            FrmLocalidadesEdit frm = new FrmLocalidadesEdit() { Text = "Editar Localidad" };
            frm.SetLocalidad(localidad);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                localidad = frm.GetLocalidad();


                if (_servicio.Existe(localidad))
                {

                    HelperMessageBox.Message(this, GuiMessageManager.ExistingRecord(), "Error", MessageType.Error);
                    return;
                }

                int registrosGuardados = _servicio.Editar(localidad);
                if (registrosGuardados == 0)
                {
                    HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(), "Mensaje",
                        MessageType.Warning);
                    RecargarGrilla();

                    return;
                }

                HelperMessageBox.Message(this, GuiMessageManager.RecordsUpdated(registrosGuardados), "Mensaje", MessageType.Information);

                HelperGrid.SetearFila(r, localidad);

            }
            catch (Exception exception)
            {
                HelperMessageBox.Message(this, exception.Message, "Mensaje", MessageType.Error);
            }

        }

        private void ImprimirIconButton_Click(object sender, EventArgs e)
        {
            crCiudades rpt = ManejadorDeReportes.GetReporteCiudades(lista);
            FrmVisorReportes frm = new FrmVisorReportes();
            frm.SetReporte(rpt);
            frm.ShowDialog(this);
        }
    }
}
