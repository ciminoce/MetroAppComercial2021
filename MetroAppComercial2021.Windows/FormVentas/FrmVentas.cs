using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MetroAppComercial2021.Datos.Comun.UnitOfWork;
using MetroAppComercial2021.Datos.Sql.UnitOfWork;
using MetroAppComercial2021.Entidades.Entidades;
using MetroAppComercial2021.Servicios;
using MetroAppComercial2021.Servicios.Facades;
using MetroAppComercial2021.Windows.Excepciones;
using MetroAppComercial2021.Windows.FormCajas;
using MetroAppComercial2021.Windows.Helpers;
using MetroFramework.Controls;

namespace MetroAppComercial2021.Windows.FormVentas
{
    public partial class FrmVentas : MetroFramework.Forms.MetroForm
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private Usuario usuario;
        private void FrmVentas_Load(object sender, EventArgs e)
        {
            _unitOfWork = new UnitOfWorkSql();
            _servicio = new VentasServicios(_unitOfWork);
            RecargarGrilla();

        }
        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            //FrmCajasEdit frm = new FrmCajasEdit(_servicio) { Text = "Nuevo Venta" };
            //DialogResult dr = frm.ShowDialog(this);
            //RecargarGrilla();
        }

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private IUnitOfWork _unitOfWork;
        private IVentasServicios _servicio;
        private List<Venta> lista;

        private int cantidadPorPagina = 20;//Cantidad de registros a mostrar por página
        private int cantidadDeRegistros;
        private int cantidadDePaginas;
        private int paginaActual = 1;


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
            foreach (var venta in lista)
            {
                DataGridViewRow r = HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r, venta);
                HelperGrid.AgregarFila(DatosMetroGrid, r);
            }
        }

        private void EditarIconButton_Click(object sender, EventArgs e)
        {
            //if (DatosMetroGrid.SelectedRows.Count == 0)
            //{
            //    return;
            //}

            //DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
            //var venta = (Venta)r.Tag;
            //FrmCajasEdit frm = new FrmCajasEdit(_servicio) { Text = "Editar Venta" };
            //frm.SetCaja(venta);
            //DialogResult dr = frm.ShowDialog(this);
            //if (dr == DialogResult.Cancel)
            //{
            //    return;
            //}

            //try
            //{
            //    venta = frm.GetCaja();
            //    int registrosGuardados = _servicio.Editar(venta);
            //    if (registrosGuardados == 0)
            //    {
            //        HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(), "Mensaje",
            //            MessageType.Warning);
            //        RecargarGrilla();

            //        return;
            //    }

            //    HelperMessageBox.Message(this, GuiMessageManager.RecordsUpdated(registrosGuardados), "Mensaje",
            //        MessageType.Information);

            //    HelperGrid.SetearFila(r, venta);

            //}
            //catch (Exception exception)
            //{
            //    HelperMessageBox.Message(this, exception.Message, "Mensaje", MessageType.Error);
            //}


        }

        private void BorrarIconButton_Click(object sender, EventArgs e)
        {
            //if (DatosMetroGrid.SelectedRows.Count == 0)
            //{
            //    return;
            //}

            //DataGridViewRow r = DatosMetroGrid.SelectedRows[0];
            //var cajaABorrar = (Venta)r.Tag;
            //DialogResult dr = HelperMessageBox.Message(this, GuiMessageManager.ConfirmDelete(), "Confirmar");

            //if (dr == DialogResult.Yes)
            //{
            //    try
            //    {

            //        if (!_servicio.EstaRelacionado(cajaABorrar))
            //        {
            //            //Tengo que tener la venta con los detalles
            //            cajaABorrar = _servicio.GetCajaConDetalle(cajaABorrar.Id);
            //            int registrosBorrados = _servicio.Borrar(cajaABorrar);
            //            if (registrosBorrados == 0)
            //            {
            //                HelperMessageBox.Message(this, GuiMessageManager.NonExistingOrModifiedRecord(),
            //                    "Advertencia", MessageType.Warning);
            //                RecargarGrilla();
            //                return;

            //            }

            //            HelperMessageBox.Message(this, GuiMessageManager.RecordsDeleted(registrosBorrados), "Mensaje", MessageType.Information);

            //            HelperGrid.QuitarFila(DatosMetroGrid, r);

            //        }
            //        else
            //        {
            //            HelperMessageBox.Message(this, GuiMessageManager.RelatedRecords(), "Error", MessageType.Error);
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        HelperMessageBox.Message(this, ex.Message, "Error", MessageType.Error);
            //    }

            //}

        }

        private void DetalleIconButton_Click(object sender, EventArgs e)
        {
            //if (DatosMetroGrid.SelectedRows.Count == 0)
            //{
            //    return;
            //}

            //try
            //{
            //    var r = DatosMetroGrid.SelectedRows[0];
            //    Venta venta = (Venta)r.Tag;
            //    venta = _servicio.GetVentaDetalle(venta.VentaId);
            //    FrmDetalleCajas frm = new FrmDetalleCajas();
            //    frm.SetVenta(venta);
            //    frm.ShowDialog(this);

            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception);
            //    throw;
            //}
        }

        public void SetUsuario(Usuario usuario)
        {
            this.usuario = usuario;
        }

        private Cliente cliente;
        private void ConsultaPorClienteIconButton_Click(object sender, EventArgs e)
        {
            FrmBuscarVentasCliente frm = new FrmBuscarVentasCliente();
            frm.Text = "Seleccionar Cliente...";
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            paginaActual = 1;
            cliente = frm.GetCliente();
            try
            {
                cantidadDeRegistros = _servicio.GetCantidad(cliente.Id);
                cantidadDePaginas = HelperCalculos.CalcularCantidadDePaginas(cantidadDeRegistros, cantidadPorPagina);
                HelperForm.CrearBotonesPaginas(BotonesMetroPanel, cantidadDePaginas);
                AsignarEventHandlerFiltroCliente(this.BotonesMetroPanel);

                RegistrosMetroLabel.Text = cantidadDeRegistros.ToString();
                PaginasMetroLabel.Text = cantidadDePaginas.ToString();

                MostrarPaginadoFiltradoPorCliente(cliente.Id,cantidadPorPagina, paginaActual);
            }
            catch (Exception ex)
            {
                HelperMessageBox.Message(this, ex.Message, "Error", MessageType.Error);
            }
        }
        private void AsignarEventHandlerFiltroCliente(MetroPanel panel)
        {
            foreach (var control in panel.Controls)
            {
                if (control is MetroButton)
                {
                    ((Button)control).Click += MiclickFiltradoCliente;
                }
            }

        }
        private void MiclickFiltradoCliente(object sender, EventArgs e)
        {
            MetroButton b = (MetroButton)sender;
            paginaActual = int.Parse(b.Text);
            MostrarPaginadoFiltradoPorCliente(cliente.Id,cantidadPorPagina, paginaActual);
        }

        private void MostrarPaginadoFiltradoPorCliente(int clienteId, int cantXPagina, int paginaActual1)
        {
            lista = _servicio.GetLista(clienteId, cantXPagina, paginaActual);
            MostrarDatosEnGrilla();

        }

        private void ActualizarIconButton_Click(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private DateTime fechaBusqueda;
        private void ConsultaPorFechaIconButton_Click(object sender, EventArgs e)
        {
            FrmBuscarVentasFecha frm = new FrmBuscarVentasFecha();
            frm.Text = "Seleccionar Fecha...";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            paginaActual = 1;
            fechaBusqueda = frm.GetFecha();
            try
            {
                cantidadDeRegistros = _servicio.GetCantidad(fechaBusqueda);
                cantidadDePaginas = HelperCalculos.CalcularCantidadDePaginas(cantidadDeRegistros, cantidadPorPagina);
                HelperForm.CrearBotonesPaginas(BotonesMetroPanel, cantidadDePaginas);
                AsignarEventHandlerFiltroFecha(this.BotonesMetroPanel);

                RegistrosMetroLabel.Text = cantidadDeRegistros.ToString();
                PaginasMetroLabel.Text = cantidadDePaginas.ToString();

                MostrarPaginadoFiltradoPorFecha(fechaBusqueda, cantidadPorPagina, paginaActual);
            }
            catch (Exception ex)
            {
                HelperMessageBox.Message(this, ex.Message, "Error", MessageType.Error);
            }

        }

        private void AsignarEventHandlerFiltroFecha(MetroPanel panel)
        {
            foreach (var control in panel.Controls)
            {
                if (control is MetroButton)
                {
                    ((Button)control).Click += MiclickFiltradoFecha;
                }
            }
        }
        private void MiclickFiltradoFecha(object sender, EventArgs e)
        {
            MetroButton b = (MetroButton)sender;
            paginaActual = int.Parse(b.Text);
            MostrarPaginadoFiltradoPorFecha(fechaBusqueda, cantidadPorPagina, paginaActual);
        }

        private void MostrarPaginadoFiltradoPorFecha(DateTime fecha, int cantidadPorPagina, int paginaActual1)
        {
            lista = _servicio.GetLista(fecha, cantidadPorPagina, paginaActual);
            MostrarDatosEnGrilla();
        }

        private void NuevoIconButton_Click_1(object sender, EventArgs e)
        {
            FrmVentasEdit frm = new FrmVentasEdit(){Text = "Nueva Venta"};
            DialogResult dr = frm.ShowDialog(this);
            if (dr==DialogResult.Cancel)
            {
                return;
            }

            try
            {
                var venta = frm.GetVenta();
                _servicio.Agregar(venta);
                var r=HelperGrid.ConstruirFila(DatosMetroGrid);
                HelperGrid.SetearFila(r,venta);
                HelperGrid.AgregarFila(DatosMetroGrid,r);
                HelperMessageBox.Message(this, "Venta Agregada","Mensaje", MessageType.Information);
            }
            catch (Exception exception)
            {
                HelperMessageBox.Message(this, exception.Message,"Error", MessageType.Error);
            }

        }
    }
}
