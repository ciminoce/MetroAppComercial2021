using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Datos.Sql.UnitOfWork;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios;
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Excepciones;
using MetroAppComercial2021.Windows.Helpers;
using MetroFramework;
using MetroFramework.Controls;

namespace MetroAppComercial2021.Windows.FormRellenos
{
    public partial class FrmRellenos : MetroFramework.Forms.MetroForm
    {
        public FrmRellenos()
        {
            InitializeComponent();
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IRellenosServicios _servicio;
        private IUnitOfWork _unitOfWork;
        private List<TipoRelleno> rellenos;
        private Usuario usuario;

        public void SetUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }
        private void FrmRellenos_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new RellenosServicios(_unitOfWork);
            RecargarGrillaRellenos();
            VerificarPermisos();
        }

        private void VerificarPermisos()
        {
            //Si el usuario es administrador 
            //no chequeo nada y me voy
            if (usuario.Rol.NombreRol == "Administrador")
            {
                return;
            }

            foreach (var control in this.Controls)
            {
                if (control is IconButton)
                {
                    string opcionTile = (string)((IconButton)control).Tag;
                    ((IconButton)control).Enabled = usuario.TienePermiso(opcionTile);
                }
            }

        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosMetroGrid);
            foreach (var relleno in rellenos)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, relleno);
                HelperGrid.AgregarFila(DatosMetroGrid, r);
            }
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmRellenosEdit frm = new FrmRellenosEdit();
            frm.Text = "Agregar Nuevo Relleno";
            DialogResult dr = frm.ShowDialog(this);
            if (dr != DialogResult.OK) return;
            try
            {
                TipoRelleno tipoRelleno = frm.GetRelleno();
                if (_servicio.Existe(tipoRelleno))
                {
                    HelperMessageBox.Message(this, GuiMessageManager.ExistingRecord(), "Error", MessageType.Error);
                    return;
                }

                int registrosAgregados = _servicio.Agregar(tipoRelleno);
                if (registrosAgregados == 0)
                {
                    HelperMessageBox.Message(this, GuiMessageManager.NonRecordsAdded(), "Advertencia",
                        MessageType.Warning);
                    return;
                }

                HelperMessageBox.Message(this, GuiMessageManager.RecordsAdded(registrosAgregados), "Mensaje",
                    MessageType.Information);

                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, tipoRelleno);
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
            var tipoRelleno = (TipoRelleno)r.Tag;
            DialogResult dr = HelperMessageBox.Message(this, GuiMessageManager.ConfirmDelete(), "Confirmar");

            if (dr == DialogResult.Yes)
            {
                try
                {

                    if (!_servicio.EstaRelacionado(tipoRelleno))
                    {
                        int registrosBorrados = _servicio.Borrar(tipoRelleno);
                        if (registrosBorrados == 0)
                        {
                            HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(),
                                "Advertencia", MessageType.Warning);
                            RecargarGrillaRellenos();
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

        private void RecargarGrillaRellenos()
        {
            try
            {
                rellenos = _servicio.GetLista();
                MostrarDatosEnGrilla();
            }
            catch (Exception exception)
            {
                HelperMessageBox.Message(this, exception.Message, "Error", MessageType.Error);
                Close();
            }
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {

            if (DatosMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
            var tipoRelleno = (TipoRelleno)r.Tag;
            FrmRellenosEdit frm = new FrmRellenosEdit() { Text = "Editar Relleno" };
            frm.SetRelleno(tipoRelleno);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                tipoRelleno = frm.GetRelleno();


                if (_servicio.Existe(tipoRelleno))
                {

                    HelperMessageBox.Message(this, GuiMessageManager.ExistingRecord(), "Error", MessageType.Error);
                    return;
                }

                int registrosGuardados = _servicio.Editar(tipoRelleno);
                if (registrosGuardados == 0)
                {
                    HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(), "Mensaje",
                        MessageType.Warning);
                    RecargarGrillaRellenos();

                    return;
                }

                HelperMessageBox.Message(this, GuiMessageManager.RecordsUpdated(registrosGuardados), "Mensaje", MessageType.Information);

                HelperGrid.SetearFila(r, tipoRelleno);

            }
            catch (Exception exception)
            {
                HelperMessageBox.Message(this, exception.Message, "Mensaje", MessageType.Error);
            }

        }
    }
}
