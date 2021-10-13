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

namespace MetroAppComercial2021.Windows.FrmUsuarios
{
    public partial class FrmUsuarios : MetroFramework.Forms.MetroForm
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        private IUnitOfWork _unitOfWork;
        private IUsuariosServicios _servicio;
        private List<Usuario> lista;
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new UsuariosServicios(_unitOfWork);
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
            foreach (var usuario in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, usuario);
                HelperGrid.AgregarFila(DatosMetroGrid, r);
            }
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmUsuariosEdit frm = new FrmUsuariosEdit();
            frm.Text = "Agregar Nueva Usuario";
            DialogResult dr = frm.ShowDialog(this);
            if (dr != DialogResult.OK) return;
            try
            {
                Usuario usuario = frm.GetUsuario();
                if (_servicio.Existe(usuario))
                {
                    HelperMessageBox.Message(this, GuiMessageManager.ExistingRecord(), "Error", MessageType.Error);
                    return;
                }

                int registrosAgregados = _servicio.Agregar(usuario);
                if (registrosAgregados == 0)
                {
                    HelperMessageBox.Message(this, GuiMessageManager.NonRecordsAdded(), "Advertencia",
                        MessageType.Warning);
                    return;
                }

                HelperMessageBox.Message(this, GuiMessageManager.RecordsAdded(registrosAgregados), "Mensaje",
                    MessageType.Information);

                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, usuario);
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
            var usuario = (Usuario)r.Tag;
            DialogResult dr = HelperMessageBox.Message(this, GuiMessageManager.ConfirmDelete(), "Confirmar");

            if (dr == DialogResult.Yes)
            {
                try
                {

                    int registrosBorrados = _servicio.Borrar(usuario);
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
            var usuario = (Usuario)r.Tag;
            FrmUsuariosEdit frm = new FrmUsuariosEdit() { Text = "Editar Usuario" };
            frm.SetUsuario(usuario);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                usuario = frm.GetUsuario();


                if (_servicio.Existe(usuario))
                {

                    HelperMessageBox.Message(this, GuiMessageManager.ExistingRecord(), "Error", MessageType.Error);
                    return;
                }

                int registrosGuardados = _servicio.Editar(usuario);
                if (registrosGuardados == 0)
                {
                    HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(), "Mensaje",
                        MessageType.Warning);
                    RecargarGrilla();

                    return;
                }

                HelperMessageBox.Message(this, GuiMessageManager.RecordsUpdated(registrosGuardados), "Mensaje", MessageType.Information);

                HelperGrid.SetearFila(r, usuario);

            }
            catch (Exception exception)
            {
                HelperMessageBox.Message(this, exception.Message, "Mensaje", MessageType.Error);
            }

        }

    }
}
