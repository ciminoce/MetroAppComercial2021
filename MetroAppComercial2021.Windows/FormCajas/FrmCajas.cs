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
using MetroAppComercial2021.Windows.FormBombones;
using MetroAppComercial2021.Windows.Helpers;
using MetroFramework.Controls;

namespace MetroAppComercial2021.Windows.FormCajas
{
    public partial class FrmCajas : MetroFramework.Forms.MetroForm
    {
        public FrmCajas()
        {
            InitializeComponent();
        }
        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            FrmCajasEdit frm = new FrmCajasEdit(_servicio) { Text = "Nuevo Caja" };
            DialogResult dr = frm.ShowDialog(this);
            RecargarGrilla();
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IUnitOfWork _unitOfWork;
        private ICajasServicios _servicio;
        private List<Caja> lista;

        private int cantidadPorPagina = 15;//Cantidad de registros a mostrar por página
        private int cantidadDeRegistros;
        private int cantidadDePaginas;
        private int paginaActual = 1;

        private void FrmCajas_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new CajasServicios(_unitOfWork);
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                cantidadDeRegistros = _servicio.GetCantidad();
                cantidadDePaginas = HelperCalculos.CalcularCantidadDePaginas(cantidadDeRegistros, cantidadPorPagina);
                HelperForm.CrearBotonesPaginas(BotonesMetroPanel, cantidadDePaginas);
                AsignarEventHandler(this.BotonesMetroPanel);

                RegistrosMetroLabel.Text = cantidadDeRegistros.ToString();
                PaginasMetroLabel.Text = cantidadDePaginas.ToString();

                MostrarPaginado(cantidadPorPagina, paginaActual);
            }
            catch (Exception e)
            {
                HelperMessageBox.Message(this, e.Message, "Error", MessageType.Error);
            }
        }

        private void AsignarEventHandler(MetroPanel panel)
        {
            foreach (var control in panel.Controls)
            {
                if (control is MetroButton)
                {
                    ((Button)control).Click += Miclick;
                }
            }

        }
        private void Miclick(object sender, EventArgs e)
        {
            MetroButton b = (MetroButton)sender;
            paginaActual = int.Parse(b.Text);
            MostrarPaginado(cantidadPorPagina, paginaActual);
        }
        private void MostrarPaginado(int cantidadPorPagina, int paginaActual)
        {
            lista = _servicio.GetListaPaginada(cantidadPorPagina, paginaActual);
            MostrarDatosEnGrilla();

        }

        private void MostrarDatosEnGrilla()
        {
            HelperGrid.LimpiarGrilla(DatosMetroGrid);
            foreach (var caja in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, caja);
                HelperGrid.AgregarFila(DatosMetroGrid, r);
            }
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
            var caja = (Caja)r.Tag;
            FrmCajasEdit frm = new FrmCajasEdit(_servicio) { Text = "Editar Caja" };
            frm.SetCaja(caja);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {
                caja = frm.GetCaja();
                int registrosGuardados = _servicio.Editar(caja);
                if (registrosGuardados == 0)
                {
                    HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(), "Mensaje",
                        MessageType.Warning);
                    RecargarGrilla();

                    return;
                }

                HelperMessageBox.Message(this, GuiMessageManager.RecordsUpdated(registrosGuardados), "Mensaje",
                    MessageType.Information);

                HelperGrid.SetearFila(r, caja);

            }
            catch (Exception exception)
            {
                HelperMessageBox.Message(this, exception.Message, "Mensaje", MessageType.Error);
            }


        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosMetroGrid.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
            var b = (Caja)r.Tag;
            DialogResult dr = HelperMessageBox.Message(this, GuiMessageManager.ConfirmDelete(), "Confirmar");

            if (dr == DialogResult.Yes)
            {
                try
                {

                    if (!_servicio.EstaRelacionado(b))
                    {
                        int registrosBorrados = _servicio.Borrar(b);
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

        private void DetalleIconButton_Click(object sender, EventArgs e)
        {
            if (DatosMetroGrid.SelectedRows.Count==0)
            {
                return;
            }

            try
            {
                var r = DatosMetroGrid.SelectedRows[0];
                Caja caja = (Caja) r.Tag;
                caja = _servicio.GetCajaConDetalle(caja.Id);
                FrmDetalleCajas frm = new FrmDetalleCajas();
                frm.SetCaja(caja);
                frm.ShowDialog(this);

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
